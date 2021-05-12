using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class OrderConfirm : Form
    {
        Order order;
        FireBaseService db = new FireBaseService() ;
        Customer customer;
        public OrderConfirm(Order selectedOrder)
        {
            InitializeComponent();
            order = selectedOrder;
            cartListView.View = View.Details;
            cartListView.LabelEdit = false;
            cartListView.AllowColumnReorder = true;
            cartListView.CheckBoxes = false;
            cartListView.GridLines = true;
            cartListView.Columns.Add("Étel", 100, HorizontalAlignment.Left);
            cartListView.Columns.Add("Mennyiség", 100, HorizontalAlignment.Right);
            cartListView.Columns.Add("Ár", 100, HorizontalAlignment.Right);
            int index = 0;
            foreach (var item in selectedOrder.Foods)
            {
                ListViewItem item1 = new ListViewItem(item.Name, index);
                item1.SubItems.Add(item.Quantity.ToString());
                int price = item.Quantity * item.Price;
                item1.SubItems.Add(price.ToString());
                cartListView.Items.Add(item1);
                index++;
            }
            
            totalPriceLabel.Text =  selectedOrder.TotalPrice().ToString() + "Ft";
            nameLabel.Text = "asd";
            cityLabel.Text = order.Address.City;
            streetLabel.Text = order.Address.Street;
            houseNumberLabel.Text = order.Address.HouseNumber.ToString();
            takeAwayLabel.Text = order.TakeAway ? "Házhozszállítás" : "Személyes átvitel";
           
            setCustomerAndRestaurantFields();

        }
        private async void setCustomerAndRestaurantFields()
        {
            customer = await db.GetCustomer(order.CustomerID);
            Restaurant restaurant = await db.GetRestaurant(order.RestaurantID);
            if(customer == null)
            {
                nameLabel.Text = order.CustomerID;
            }
            else
            {
                nameLabel.Text = customer.Name;
            }
            estimatedDeliveryButton.Value = restaurant.DeliveryTime;
            order.EstimatedDeliveryTime = restaurant.DeliveryTime;
        }

        private void acceptButton_ClickAsync(object sender, EventArgs e)
        {
            order.Status = Status.Accepted;
            setOrder();
            this.Close();
        }

        private void refuseButton_ClickAsync(object sender, EventArgs e)
        {
            order.Status = Status.Refused;
            setOrder();
            this.Close();
            
        }
        private async void setOrder()
        {
            await db.AddOrder(order);
        }

        private void estimatedDeliveryButton_ValueChanged(object sender, EventArgs e)
        {
            order.EstimatedDeliveryTime = Convert.ToInt32(estimatedDeliveryButton.Value);
        }
    }
}
