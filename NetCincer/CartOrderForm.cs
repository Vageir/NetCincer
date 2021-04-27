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
            addressTextBox.Text = customer.Address.ToString();
            usernameTextBox.Text = customer.CustomerID;
            cartListView.View = View.Details;
            cartListView.Columns.Add("Étel");
            cartListView.Columns.Add("Mennyiség", 200, HorizontalAlignment.Center);

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
