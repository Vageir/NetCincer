using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace NetCincer
{
    public partial class CourierMain : Form
    {
        private Courier linCourier;
        FireBaseService db = new FireBaseService();
        private List<Order> orders;
        private List<Order> selectedOrders;
        private ListView listView1 = new ListView();
        private FirestoreChangeListener listener;
        private int sortColumn = 0;
        public CourierMain(ref Courier cour)
        {
            linCourier = cour;
            InitializeComponent();
            CreateMyListView();
            listView1.Visible = false;
            listener = db.CreateQueryForListener("orders", "CourierID", cour.CourierID).Listen(
             snapshot =>
             {
                 orders = new List<Order>();
                 foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
                 {
                     Order o = documentSnapshot.ConvertTo<Order>();
                     o.OrderID = documentSnapshot.Id;
                     orders.Add(o);
                 }

                 //orders.Sort((x, y) => x.Status.CompareTo(y.Status));

                 orders = orders.OrderBy(order => order.Status).ToList();
                 listView1.Invoke(new Action(() => { refreshOrdersList(); }));
             });
            //db.changeAvailabity(linCourier.CourierID, false);
        }

        async private void workButton_Click(object sender, EventArgs e)
        {
            if (workButton.Text == "Dolgozom")
            {
                workButton.Text = "Végeztem";
                try
                {
                    if (linCourier.CourierID == null)
                    {
                        Debug.WriteLine("CourierID is null");
                    }
                    await db.changeAvailabity(linCourier.CourierID, true);
                    listView1.Visible = true;
                    acceptButton.Visible = true;
                    refuseButton.Visible = true;
                    deliveredButton.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a munka indításában.");
                    workButton.Text = "Dolgozom";
                }
            }
            else
            {
                workButton.Text = "Dolgozom";
                try
                {
                    await db.changeAvailabity(linCourier.CourierID, false);
                    listView1.Visible = false;
                    acceptButton.Visible = false;
                    refuseButton.Visible = false;
                    deliveredButton.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a munkából kijelentkezésben.");
                    workButton.Text = "Végeztem";
                }
            }
        }

        private void CreateMyListView()
        {
            // Create a new ListView control.

            listView1.Bounds = new Rectangle(new Point(10, 40), new Size(1085, 445));
            // Adding sorting click handler || Joe
            listView1.ColumnClick += columnSort;
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
            this.Controls.Add(listView1);
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
                    names += $"{food.Name}({food.Quantity}),";
                }
                //Debug.WriteLine(names.Length);
                names = names.Remove(names.Length - 1); // Leveszi az utolso vesszot

                order = new ListViewItem(orders[i].Address.ToString(), i);
                order.Tag = orders[i].OrderID;
                order.SubItems.Add(names);
                order.SubItems.Add(orders[i].OrderDate);
                order.SubItems.Add(orders[i].EstimatedDeliveryTime.ToString() + " perc");
                order.SubItems.Add(orders[i].Status.ToString());
                if (orders[i].CourierID != null)
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
            listView1.Columns.Add("Cím", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Ételek(db)", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Rendelési idő", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Várható kiszállítási idő", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Állapot", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Futár", 40, HorizontalAlignment.Center);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void cuLogoutButton_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }

        private async void acceptButton_ClickAsync(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && areAllTheSameStatus(Status.ReadyToDeliver))
            {
                setSelectedOrders();
                DialogResult dialogResult = MessageBox.Show("Biztos elfogadja?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    foreach (Order order in selectedOrders)
                    {
                        order.Status = Status.Delivery;
                        await db.AddOrder(order);
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void columnSort(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listView1.Sorting == SortOrder.Ascending)
                {
                    listView1.Sorting = SortOrder.Descending;
                }
                else
                {
                    listView1.Sorting = SortOrder.Ascending;
                }
            }
            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
        }

        private void refuseButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && areAllTheSameStatus(Status.ReadyToDeliver))
            {
                setSelectedOrders();
                DialogResult dialogResult = MessageBox.Show("Biztos elutasítja?", "Megerősítés", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    selectedOrders.ForEach(async order => { order.Status = Status.DeliveryRefused; order.CourierID = null; await db.AddOrder(order); });
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
        }

        private void deliveredButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && areAllTheSameStatus(Status.Delivery))
            {
                setSelectedOrders();
                DialogResult dialogResult = MessageBox.Show("Kiszállítva?", "Megerősítés", MessageBoxButtons.YesNo);
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
        private void setSelectedOrders()
        {
            List<String> selectedIDs = new List<string>();
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                selectedIDs.Add(listView1.SelectedItems[i].Tag.ToString());
            }
            selectedOrders = orders.Where(p1 => selectedIDs.Any(p2 => p2.Equals( p1.OrderID))).Distinct().ToList();

        }
        private bool areAllTheSameStatus(Status refStatus)
        {

            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                Status status = (Status)Enum.Parse(typeof(Status), listView1.SelectedItems[i].SubItems[4].Text.ToString());
                if (status != refStatus)
                    return false;
            }
            return true;
        }

        private void CourierMain_Load(object sender, EventArgs e)
        {

        }
    }
}
