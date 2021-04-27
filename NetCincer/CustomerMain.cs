using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Diagnostics;

namespace NetCincer
{
    public partial class CustomerMain : Form
    {
        private Customer linCustomer;
        private List<Restaurant> restaurants;
        private List<Food> foods;
        private ListView listView1 = new ListView();
        //private ObjectListView listView2 = new ObjectListView();
        private FireBaseService db = new FireBaseService();
        private Restaurant selectedRestaurant;

        public CustomerMain(ref Customer linC)
        {
            linCustomer = linC;
            InitializeComponent();
            CreateMyListView();
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

            listView1.Font = new Font("Consolas", 20f);
            ListViewItem etterem;
            try
            {
                restaurants = await db.ListRestaurants();
                for (int i = 0; i < restaurants.Count; ++i)
                {
                    etterem = new ListViewItem(restaurants[i].RestaurantName, i);

                    etterem.SubItems.Add(restaurants[i].DeliveryTime.ToString());
                    listView1.Items.Add(etterem);
                }
                //listView1.Columns.Add("UP", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Név", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Kiszállítási idő", -2, HorizontalAlignment.Center);

                // Add the ListView to the control collection.
                this.Controls.Add(listView1);
                refreshList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        async void refreshList()
        {
            try
            {
                addToCartButton.Enabled = false;
                foodsButton.Enabled = true;
                listView1.Items.Clear();
                restaurants = await db.ListRestaurants();
                ListViewItem etterem;
                for (int i = 0; i < restaurants.Count; ++i)
                {
                    etterem = new ListViewItem(restaurants[i].RestaurantName, i);
                    etterem.SubItems.Add(restaurants[i].DeliveryTime.ToString());
                    listView1.Items.Add(etterem);
                }
            }
            catch( Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        async void listFoods(Restaurant clickedRestaurant)
        {
            this.selectedRestaurant = clickedRestaurant;
            try
            {
                listView1.Items.Clear();
                listView1.Columns.Clear();
                foods = await db.ListFoods(clickedRestaurant.RestaurantID);
                ListViewItem etel;
                for (int i = 0; i < foods.Count; ++i)
                {
                    if ((foods[i].StartPeriod == null && foods[i].EndPeriod == null)
                        || ((0 >= DateTime.Compare(DateTime.Parse(foods[i].StartPeriod), DateTime.Now)) && (0 < DateTime.Compare(DateTime.Parse(foods[i].EndPeriod), DateTime.Now))))
                    {
                        etel = new ListViewItem(foods[i].Name, i);
                        etel.SubItems.Add(foods[i].Category);
                        etel.SubItems.Add(foods[i].Allergens);
                        etel.SubItems.Add(foods[i].Price.ToString());
                        etel.SubItems.Add(foods[i].Description);
                        listView1.Items.Add(etel);
                    }
                    
                }
                // todo: itt az oszlopok mérete nem stimmel, a név túl széles
                listView1.Columns.Add("Név", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Kategória", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Allergének", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Ár", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Leírás", -2, HorizontalAlignment.Center);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void foodsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    foodsButton.Enabled = false;
                    goBackButton.Enabled = true;
                    addToCartButton.Enabled = true;
                    String restaurantName = listView1.SelectedItems[0].SubItems[0].Text;
                    for (int i = 0; i < restaurants.Count; ++i)
                    {
                        if (restaurants[i].RestaurantName.Equals(restaurantName))
                        {
                            listFoods(restaurants[i]);
                            return;
                        }
                    }
                }
                else
                {
                    // ide valamiért be se lép, a listView1.SelectedItems[0] sosem lesz null
                    MessageBox.Show("Kérem válasszon ki egy éttermet!", "Hiba");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(linCustomer,selectedRestaurant.RestaurantID);
            cartForm.Show();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            addToCartButton.Enabled = false;
            goBackButton.Enabled = false;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            CreateMyListView();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    int db = 1;     // todo: ezt majd meg kell kérdezni a customert mennyi legyen
                    string foodName = listView1.SelectedItems[0].SubItems[0].Text;
                    for (int i = 0; i < foods.Count; ++i)
                    {
                        if (foods[i].Name.Equals(foodName))
                        {
                            linCustomer.Cart.AddFood(foods[i], db);
                            MessageBox.Show(foods[i].Name + "(" + db + ") kosárba rakva!", "Info");
                            return;
                        }
                    }
                    
                    
                }
                else
                {
                    // ide valamiért be se lép, a listView1.SelectedItems[0] sosem lesz null
                    MessageBox.Show("Kérem válasszon ki egy éttermet!", "Hiba");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Hide();
        }
    }
}
