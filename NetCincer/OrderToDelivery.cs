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
        public OrderToDelivery(List<Order> ordersReady)
        {
            InitializeComponent();
            this.Orders = ordersReady;
            PossibleToDeliveryCouriers = new List<Courier>();
            init();
        }
        private async void init()
        {
            List<String> cities = Orders.Select(o => o.Address.City).ToList();
            List<Courier> Couriers = await db.ListAvailableCouriers(cities);
            if (Couriers.Count > 0)
            {
                foreach(Courier courier in Couriers)
                {
                    if (new HashSet<string>(cities).IsSupersetOf(courier.Cities))
                        PossibleToDeliveryCouriers.Add(courier);
                }
            }
            else
            {
                isItPossibleLabel.Visible = true;
                isItPossibleLabel.Text = "Nincsen elérhető szállító";
            }
            Debug.WriteLine(PossibleToDeliveryCouriers.Count);

        }
        private void giveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
