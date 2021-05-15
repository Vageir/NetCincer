using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class CustomerOrderHistoryForm : Form
    {
        private List<Order> orders;
        private ListView listView1 = new ListView();
        private FireBaseService db = new FireBaseService();
        private FirestoreChangeListener listener;
        public CustomerOrderHistoryForm(Customer customer)
        {
            InitializeComponent();
            CreateMyListView();
            listener = db.CreateQueryForListener("orders", "CustomerID", customer.CustomerID).Listen(
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
                          listView1.Invoke(new Action(() => { refreshOrdersList(); }));
                     }
              });
        }
         private void CreateMyListView()
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

                order = new ListViewItem(names, i);
                order.Tag = orders[i].OrderID;
                order.SubItems.Add(orders[i].OrderDate);
                order.SubItems.Add(orders[i].TakeAway ? "Igen" : "Nem");
                order.SubItems.Add(orders[i].Status.ToString());
                order.SubItems.Add(orders[i].EstimatedDeliveryTime.ToString() + " perc");
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
            listView1.Columns.Add("Ételek(db)", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Rendelési idő", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Elvitel", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Állapot", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Várható kiszállítási idő", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("Futár", 40, HorizontalAlignment.Center);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
            
        }

    }
}
