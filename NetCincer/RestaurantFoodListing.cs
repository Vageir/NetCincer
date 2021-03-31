using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class RestaurantFoodListing : Form
    {
        private Restaurant linRestaurant;
        public RestaurantFoodListing(ref Restaurant rest)
        {
            linRestaurant = rest;
            InitializeComponent();
        }

        private void rNewFoodButton_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood(ref linRestaurant);
            addFood.Show();
        }
    }
}
