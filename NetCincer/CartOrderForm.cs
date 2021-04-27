using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class CartOrderForm : Form
    {
        private Customer Customer;
        private String RestaurantID;
        public CartOrderForm(Customer customer, String restaurantID)
        {
            this.RestaurantID = restaurantID;
            InitializeComponent();
            this.Customer = customer;
            if (customer.Name != null)
            {
                addressTextBox.Text = customer.Address.ToString();
                usernameTextBox.Text = customer.CustomerID;
            }
            cartListView.View = View.Details;
            cartListView.LabelEdit = false;
            cartListView.AllowColumnReorder = true;
            cartListView.CheckBoxes = false;
            cartListView.Columns.Add("Étel",100, HorizontalAlignment.Left);
            cartListView.Columns.Add("Mennyiség", 100, HorizontalAlignment.Right);
            cartListView.Columns.Add("Ár", 100, HorizontalAlignment.Right);
            foreach (var item in customer.Cart.GetFoods())
            {
                ListViewItem item1 = new ListViewItem("item1", 0);
                item1.SubItems.Add(item.Key.Name);
                item1.SubItems.Add(item.Value.ToString());
                int price = item.Value * item.Key.Price;
                item1.SubItems.Add(price.ToString());
                cartListView.Items.Add(item1);
            }
           
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
