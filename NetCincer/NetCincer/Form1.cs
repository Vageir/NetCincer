using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class Form1 : Form
    {
        private Customer linCustomer;
        List<Restaurant> restaurants;
        FireBaseService db = new FireBaseService();
        public Form1(Customer linC)
        {
            linCustomer = linC;
            InitializeComponent();
            CreateMyListView();
        }
        async private void CreateMyListView()
        {
            // Create a new ListView control.
            ListView listView1 = new ListView();
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

            // Create three items and three sets of subitems for each item.
            /*ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");*/

            //ListViewItem[] items;
            restaurants = await db.ListRestaurants();
            for(int i = 0; i < restaurants.Count; ++i)
            {
                ListViewItem etterem = new ListViewItem(restaurants[i].RestaurantName, i);
                //etterem.Checked = false;
                //etterem.SubItems.Add(restaurants[i].RestaurantName);
                etterem.SubItems.Add(restaurants[i].DeliveryTime.ToString());
                listView1.Items.Add(etterem);
            }
            //listView1.Columns.Add("UP", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Név", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Kiszállítási idő", -2, HorizontalAlignment.Center);

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            /*listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);*/

            //Add the items to the ListView.
            //listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            
            // Create two ImageList objects.
            /*ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();*/

            // Initialize the ImageList objects with bitmaps.
            /*imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
            imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage1.bmp"));
            imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));*/

            //Assign the ImageList objects to the ListView.
            /*listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;*/

            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }
    }
}
