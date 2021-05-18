using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class OrderToDelivery : Form
    {
        private List<Order> Orders;
        private List<Courier> PossibleToDeliveryCouriers;
        private FireBaseService db = new FireBaseService();
        public OrderToDelivery(ref List<Order> ordersReady)
        {
            InitializeComponent();
            this.Orders = ordersReady;
            PossibleToDeliveryCouriers = new List<Courier>();
            init();
        }
        private async void init()
        {
           
            List<String> cities = Orders.Select(order => order.Address.City).ToList();
            List<String> distincCities = cities.Distinct().ToList(); 
            List<Courier> Couriers = await db.ListAvailableCouriers();
            if (Couriers.Count > 0)
            {
                foreach (Courier courier in Couriers)
                {
                    if (distincCities.Intersect(courier.Cities).Count() == distincCities.Count)
                    {
                        PossibleToDeliveryCouriers.Add(courier);
                    }
                }
                if(PossibleToDeliveryCouriers.Count > 0)
                {
                    foreach (Courier item in PossibleToDeliveryCouriers)
                    {
                        deliveryComboBox.Items.Add(new ComboboxValue(item.Name,item.CourierID)); 
                    }
                    deliveryComboBox.SelectedItem = deliveryComboBox.Items[0];
                    giveButton.Enabled = true;
                }
                else
                {
                    giveButton.Enabled = false;
                    isItPossibleLabel.Visible = true;
                    isItPossibleLabel.Text = "Nincsen olyan szállító aki képes lenne rendelést kiszálítani";
                }
            }
            else
            {
                giveButton.Enabled = false;
                isItPossibleLabel.Visible = true;
                isItPossibleLabel.Text = "Nincsen elérhető szállító";
            }
            Debug.WriteLine(Couriers.Count);

        }
        private async void giveButton_Click(object sender, EventArgs e)
        {
            ComboboxValue asd = (ComboboxValue) deliveryComboBox.SelectedItem;
            string id = asd.CourierID;
            //Courier courier = PossibleToDeliveryCouriers.Find(courier => courier.CourierID == id);
            foreach (Order order in Orders)
            {
                order.CourierID = id;
                order.Status = Status.ReadyToDeliver;
                await db.AddOrder(order);
            }
            this.Close();
        }

         class ComboboxValue
        {
            public String CourierID { get; private set; }
            public String Name { get; private set; }

            public ComboboxValue(string name, string courierID)
            {
                this.Name = name;
                this.CourierID = courierID;
            }
            public override string ToString()
            {
                return Name;
            }
            
        }
    }
}
