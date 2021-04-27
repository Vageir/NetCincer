using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class CartForm : Form
    {
        private ListView CartListView = new ListView();
        Customer Customer;
        String RestaurantID;
        public CartForm(Customer customer, String restaurantID)
        {
            InitializeComponent();
            this.Customer = customer;
            this.RestaurantID = restaurantID;
            InitListView();
        }
        private void InitListView()
        {
            CartListView.Bounds = new Rectangle(new Point(12, 35), new Size(1085, 445));
            CartListView.View = View.Details;
            CartListView.LabelEdit = false;
            CartListView.AllowColumnReorder = true;
            CartListView.CheckBoxes = false;
            CartListView.Columns.Add("Étel", 100, HorizontalAlignment.Left);
            CartListView.Columns.Add("Mennyiség", 100, HorizontalAlignment.Right);
            CartListView.Columns.Add("Ár", 100, HorizontalAlignment.Right);
            int index = 0;
            foreach (var item in Customer.Cart.GetFoods())
            {
                ListViewItem item1 = new ListViewItem(item.Key.Name, index);
                item1.SubItems.Add(item.Value.ToString());
                int price = item.Value * item.Key.Price;
                item1.SubItems.Add(price.ToString());
                CartListView.Items.Add(item1);
                index++;
            }
            this.Controls.Add(CartListView);
        }
      
    }
}
