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
        private bool guest;
        public CartOrderForm(Customer customer, String restaurantID)
        {
            this.RestaurantID = restaurantID;
            InitializeComponent();
            this.Customer = customer;
            if (customer.CustomerID != null)
            {
                cityTextBox.Text = customer.Address.City;
                streetextBox.Text = customer.Address.Street;
                houseNumberNumericUpDown.Value = customer.Address.HouseNumber;
                usernameTextBox.Text = customer.Name;
            }
            else guest = true;
            cartListView.View = View.Details;
            cartListView.LabelEdit = false;
            cartListView.AllowColumnReorder = true;
            cartListView.CheckBoxes = false;
            cartListView.GridLines = true;
            cartListView.Columns.Add("Étel",100, HorizontalAlignment.Left);
            cartListView.Columns.Add("Mennyiség", 100, HorizontalAlignment.Right);
            cartListView.Columns.Add("Ár", 100, HorizontalAlignment.Right);
            int index = 0;
            foreach (var item in customer.Cart.GetFoods())
            {
                ListViewItem item1 = new ListViewItem(item.Key.Name, index);
                item1.SubItems.Add(item.Value.ToString());
                int price = item.Value * item.Key.Price;
                item1.SubItems.Add(price.ToString());
                cartListView.Items.Add(item1);
                index++;
            }
            totalPriceLabel.Text = customer.Cart.TotalPrice().ToString()+ "Ft";
        }

        private async void orderButton_Click(object sender, EventArgs e)
        {
            Customer.Cart.TakeAway = takeAwayYesRadioButton.Checked;
            Customer.MakeOrder(RestaurantID);
            await new FireBaseService().AddOrder(Customer.CurrentOrder);
            MessageBox.Show(this, "Rendelés leadva", "Rendelés", MessageBoxButtons.OK);
            this.Close();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(guest)
            {
                Customer.CustomerID = usernameTextBox.Text.ToString();
            }
            else
            {
                Customer.Name = usernameTextBox.Text.ToString();
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            Customer.Address.City = cityTextBox.Text.ToString();
        }

        private void streetextBox_TextChanged(object sender, EventArgs e)
        {
            Customer.Address.Street = streetextBox.Text.ToString();
        }

        private void houseNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Customer.Address.HouseNumber = Convert.ToInt32(Math.Round(houseNumberNumericUpDown.Value, 0));
        }
    }
}
