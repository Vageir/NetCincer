using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCincer
{
    public partial class RestaurantFoodListing : Form
    {
        private Restaurant linRestaurant;
        private List<Food> foods;
        private ListView listView1 = new ListView();
        private FireBaseService db = new FireBaseService();
        public RestaurantFoodListing(ref Restaurant rest)
        {
            linRestaurant = rest;
            InitializeComponent();
            CreateMyListView();
        }

        private void rNewFoodButton_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(ref linRestaurant);
            addFood.Show();
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
            } catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

        async void refreshList()
        {
            /*try
            {*/
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
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listView1.Columns.Clear();
            /*listView1.Columns.Clear();
            listView1.Columns.Add("Név", -1, HorizontalAlignment.Center);
            listView1.Columns.Add("Ár", -1, HorizontalAlignment.Center);
            listView1.Columns.Add("Leírás", -1, HorizontalAlignment.Center);
            listView1.Columns.Add("Ellergének", -1, HorizontalAlignment.Center);*/
            /*}
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }*/
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
            this.Close();
        }
    }
}
