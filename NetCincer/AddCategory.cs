using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class AddCategory : Form
    {
        private Restaurant linRestaurant;
        public AddCategory(ref Restaurant res)
        {
            linRestaurant = res;
            InitializeComponent();
        }

        private void cCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void cAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                FireBaseService db = new FireBaseService();
                await db.AddMenuCategory(linRestaurant.RestaurantID, textBox1.Text);
                //MessageBox.Show("Kategória hozzáadva!","Infó");
                this.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba a hozzáadásban");
            }
        }
    }
}
