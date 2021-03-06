using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class CartForm : Form
    {
        
        Customer Customer;
        String RestaurantID;
        public CartForm(Customer customer, String restaurantID)
        {
            InitializeComponent();
            Customer = customer;
            RestaurantID = restaurantID;
            InitListView();
        }
        private void InitListView()
        {
            CartListView.FullRowSelect = true;
            CartListView.MultiSelect = false;
            CartListView.GridLines = true;
            CartListView.Font = new Font("Consolas", 20f);
            CartListView.View = View.Details;
            CartListView.Columns.Add("Étel", 300, HorizontalAlignment.Left);
            CartListView.Columns.Add("Mennyiség", 200, HorizontalAlignment.Right);
            CartListView.Columns.Add("Ár", 100, HorizontalAlignment.Right);
            if (Customer.Cart.GetFoods() != null) {
                refreshList();
            }
        }

        private void emptyCartButton_Click(object sender, EventArgs e)
        {
            Customer.Cart.EmptyCart();
            CartListView.Clear();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (Customer.Cart.GetFoods().Count != 0)
            {
                CartOrderForm cartOrderForm = new CartOrderForm(Customer, RestaurantID);
                cartOrderForm.Show();
            }
        }

        private void deleteCartLine_Click(object sender, EventArgs e)
        {
            if (CartListView.SelectedItems.Count != 0)
            {
                Customer.Cart.RemoveFood(CartListView.SelectedItems[0].Tag.ToString());
                CartListView.Items.Remove(CartListView.SelectedItems[0]);
            }
        }

        private void CartListView_SelectedIndexChanged(object sender, EventArgs e)
        {  

        }

        private void changeQuantity_Click(object sender, EventArgs e)
        {
            if (CartListView.SelectedItems.Count != 0)
            {
                int input = Convert.ToInt32(CartListView.SelectedItems[0].SubItems[1].Text.ToString());
                ShowInputDialog(ref input);
                if (input == 0)
                {
                    Customer.Cart.RemoveFood(CartListView.SelectedItems[0].Tag.ToString());
                    CartListView.Items.Remove(CartListView.SelectedItems[0]);
                }
                else
                {
                    Food food = Customer.Cart.GetFood(CartListView.SelectedItems[0].Tag.ToString());
                    if (food != null)
                    {
                        Customer.Cart.SetQuantity(food, input);
                        refreshList();
                    }
                }
            }
        }
        private void refreshList()
        {
            CartListView.Items.Clear();
            foreach (var item in Customer.Cart.GetFoods())
            {
                ListViewItem item1 = new ListViewItem(item.Name);
                item1.Tag = item.FoodID;
                item1.SubItems.Add(item.Quantity.ToString());
                int discountPrice = (int)(item.Price * (double)(1 - (double)((double)item.Discount / 100)));
                int price = item.Quantity * discountPrice;
                item1.SubItems.Add(price.ToString());
                CartListView.Items.Add(item1);
            }
        }
        private static DialogResult ShowInputDialog(ref int input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Mennyiség";

            System.Windows.Forms.NumericUpDown numeric = new NumericUpDown();
            numeric.Size = new System.Drawing.Size(size.Width - 10, 23);
            numeric.Location = new System.Drawing.Point(5, 5);
            numeric.Value = input;
            numeric.Minimum = 1;
            inputBox.Controls.Add(numeric);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = Convert.ToInt32( numeric.Text);
            return result;
        }
    }
}
