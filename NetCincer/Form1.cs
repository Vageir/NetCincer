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

namespace NetCincer
{
    public partial class Form1 : Form
    {
        private Customer linCustomer;
        private List<Restaurant> restaurants;
        private ListView listView1 = new ListView();
        //private ObjectListView listView2 = new ObjectListView();
        FireBaseService db = new FireBaseService();
        public Form1(ref Customer linC)
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
            restaurants = await db.ListRestaurants();
            for(int i = 0; i < restaurants.Count; ++i)
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

        async void refreshList()
        {
            listView1.Items.Clear();
            restaurants = await db.ListRestaurants();
            ListViewItem etterem;
            for (int i = 0; i < restaurants.Count; ++i)
            {
                etterem = new ListViewItem(restaurants[i].RestaurantName, i);
                
                //etterem.Checked = false;
                //etterem.SubItems.Add(restaurants[i].RestaurantName);
                etterem.SubItems.Add(restaurants[i].DeliveryTime.ToString());
                listView1.Items.Add(etterem);
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refreshList();
        }

    }
}
