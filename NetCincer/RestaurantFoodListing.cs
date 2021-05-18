using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class RestaurantFoodListing : Form
    {
        private Restaurant linRestaurant;
        private List<Food> foods;
        private List<Order> orders;
        private ListView listView1 = new ListView();
        private FireBaseService db = new FireBaseService();
        private FirestoreChangeListener listener;
        private bool orderShow = false;
        public RestaurantFoodListing(ref Restaurant rest)
        {
            linRestaurant = rest;
            InitializeComponent();
            CreateMyListView();
            listener = db.CreateQueryForListener("orders","RestaurantID",linRestaurant.RestaurantID).Listen(
                 snapshot => {
                     orders = new List<Order>();
                     foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
                     {
                         Order o = documentSnapshot.ConvertTo<Order>();
                         o.OrderID = documentSnapshot.Id;
                         orders.Add(o);
                     }

                     //orders.Sort((x, y) => x.Status.CompareTo(y.Status));
                     if (orders != null)
                     {
                         orders = orders.OrderBy(order => order.Status).ToList();
                         
                         if (orderShow) listView1.Invoke(new Action(() => { refreshOrdersList(); }));
                     }
                 });
        }

        private void rNewFoodButton_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(ref linRestaurant);
            addFood.Show();
            refreshList();
        }

        async private void CreateMyListView()
        {
            // Create a new ListView control.

            listView1.Bounds = new Rectangle(new Point(10, 40), new Size(1085, 445));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = false;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;
            listView1.MultiSelect = true;

            listView1.Font = new Font("Consolas", 12f);
            ListViewItem food;
            
            try
            {
                foods = await db.ListFoods(linRestaurant.RestaurantID);
                if (foods != null)
                {
                    for (int i = 0; i < foods.Count; ++i)
                    {
                        food = new ListViewItem(foods[i].Name, i);
                        food.SubItems.Add(foods[i].Price.ToString() + " Ft");
                        food.SubItems.Add(foods[i].Description);
                        food.SubItems.Add(foods[i].Allergens);
                        listView1.Items.Add(food);
                    }
                    //listView1.Columns.Add("UP", -2, HorizontalAlignment.Left);
                    //listView1.Columns.Clear();
                    listView1.Columns.Add("Név", 40, HorizontalAlignment.Center);
                    listView1.Columns.Add("Ár", 40, HorizontalAlignment.Center);
                    listView1.Columns.Add("Leírás", 40, HorizontalAlignment.Center);
                    listView1.Columns.Add("Allergének", 40, HorizontalAlignment.Center);
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    // Add the ListView to the control collection.
                    this.Controls.Add(listView1);
                    refreshList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        
        async void refreshList()
        {
            /*try
            {*/
            listView1.Columns.Clear();
            listView1.Items.Clear();
            ListViewItem food;
            foods = await db.ListFoods(linRestaurant.RestaurantID);
            for (int i = 0; i < foods.Count; ++i)
            {
                food = new ListViewItem(foods[i].Name, i);
                food.SubItems.Add(foods[i].Price.ToString() + " Ft");
                food.SubItems.Add(foods[i].Description);
                food.SubItems.Add(foods[i].Allergens);
                listView1.Items.Add(food);
            }
            listView1.Columns.Add("Név", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Ár", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Leírás", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Allergének", 40, HorizontalAlignment.Center);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            orderShow = false;
            acceptRefuseButton.Visible = false;
            giveToDeliveryButton.Visible = false;
            DiscountButton.Visible = true;
            doneButton.Visible = false;
            readyButton.Visible = false;
        }

        private async void refreshOrdersList()
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Sorting = SortOrder.None;
            ListViewItem order;
            //orders = await db.ListRestaurantOrders(linRestaurant.RestaurantID);
            for (int i = 0; i < orders.Count; ++i)
            {
                string names = "";
                foreach (var food in orders[i].Foods)
                {
                    names +=  $"{food.Name}({food.Quantity}),";
                }
                //Debug.WriteLine(names.Length);
                names = names.Remove(names.Length - 1); // Leveszi az utolso vesszot

                order = new ListViewItem(names, i);
                order.Tag = orders[i].OrderID;
                order.SubItems.Add(orders[i].OrderDate);
                order.SubItems.Add(orders[i].TakeAway?"Igen":"Nem");
                order.SubItems.Add(orders[i].Status.ToString());
                if(orders[i].CourierID != null)
                {
                    String name = await db.GetCourierName(orders[i].CourierID);
                    
                    order.SubItems.Add(name);
                }
                else
                {
                    order.SubItems.Add("Nincs");
                }

                listView1.Items.Add(order);
            }           
            listView1.Columns.Add("Ételek(db)", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Rendelési idő", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Elvitel", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Állapot", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Futár", 40, HorizontalAlignment.Center);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            acceptRefuseButton.Visible = true;
            giveToDeliveryButton.Visible = true;
            DiscountButton.Visible = false;
            orderShow = true;
            doneButton.Visible = true;
            readyButton.Visible = true;
        }


        private void rlistingButton_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void rAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory newCat = new AddCategory(ref linRestaurant);
            newCat.Show();
        }

        private void rLogoutButton_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Hide();
            detachListener();
        }
        private async void detachListener()
        {
            await listener.StopAsync(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshOrdersList();
        }

        private void acceptRefuseButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1) 
            {
                Order selectedOrder = orders.Find(o => o.OrderID.Equals(listView1.SelectedItems[0].Tag));
                if(selectedOrder.Status == Status.Pending)
                {
                    OrderConfirm orderConfirm = new OrderConfirm(selectedOrder);
                    orderConfirm.Show();
                }
            }
        }

        private void giveToDeliveryButton_Click(object sender, EventArgs e)
        {
            List<Order> ordersReady = new List<Order>();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                Order selectedOrder = orders.Find(o => o.OrderID.Equals(listView1.SelectedItems[i].Tag));
                if (selectedOrder.Status == Status.Accepted || selectedOrder.Status == Status.Ready || selectedOrder.Status == Status.DeliveryRefused)
                {
                    ordersReady.Add(selectedOrder);
                }
                else break;
            }
            if (ordersReady.Count > 0)
            {
                OrderToDelivery orderToDelivery = new OrderToDelivery(ref ordersReady);
                orderToDelivery.Show();
            }
        }

        private void rProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void RestaurantFoodListing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void DiscountButton_Click(object sender, EventArgs e)
        {
            int discount = 0;
            string foodName = listView1.SelectedItems[0].SubItems[0].Text;
            ShowInputDialog(ref discount);
            for (int i = 0; i < linRestaurant.Foods.Count; ++i)
            {
                if (linRestaurant.Foods[i].Name.Equals(foodName))
                {
                    linRestaurant.Foods[i].Discount = discount;
                    await db.AddRestaurant(linRestaurant);
                    return;
                }
            }
        }

        private static DialogResult ShowInputDialog(ref int input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Leárazás";

            System.Windows.Forms.NumericUpDown numeric = new NumericUpDown();
            numeric.Size = new System.Drawing.Size(size.Width - 10, 23);
            numeric.Location = new System.Drawing.Point(5, 5);
            numeric.Value = input;
            numeric.Minimum = 0;
            numeric.Maximum = 99;
            inputBox.Controls.Add(numeric);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = Convert.ToInt32(numeric.Text);
            return result;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && areAllTheSameStatus(Status.Ready) && areAllTakeAway())
            {
                List<Order> selectedOrders = setSelectedOrders();
                DialogResult dialogResult = MessageBox.Show("Átadva ?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    selectedOrders.ForEach(async order => { order.Status = Status.Completed; await db.AddOrder(order); });
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
        private bool areAllTheSameStatus(Status refStatus)
        {

            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                Status status = (Status)Enum.Parse(typeof(Status), listView1.SelectedItems[i].SubItems[3].Text.ToString());
                if (status != refStatus)
                    return false;
            }
            return true;
        }
        private bool areAllTakeAway()
        {

            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                bool takeAway = listView1.SelectedItems[i].SubItems[2].Text.ToString().Equals( "Igen");
                if (!takeAway)
                    return false;
            }
            return true;
        }
        private List<Order> setSelectedOrders()
        {
            List<Order> selectedOrders = new List<Order>();
            List<String> selectedIDs = new List<string>();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                selectedIDs.Add(listView1.SelectedItems[i].Tag.ToString());
            }
            selectedOrders = orders.Where(p1 => selectedIDs.Any(p2 => p2.Equals(p1.OrderID))).Distinct().ToList();
            return selectedOrders;
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && areAllTheSameStatus(Status.Accepted) )
            {
                List<Order> selectedOrders = setSelectedOrders();
                DialogResult dialogResult = MessageBox.Show("Kész?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    selectedOrders.ForEach(async order => { order.Status = Status.Ready; await db.AddOrder(order); });
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }
    }
}
