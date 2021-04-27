using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class CourierMain : Form
    {
        private Courier linCourier;
        public CourierMain(ref Courier cour)
        {
            linCourier = cour;
            InitializeComponent();
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            if (workButton.Text == "Dolgozom")
            {
                workButton.Text = "Végeztem";
            }
            else
            {
                workButton.Text = "Dolgozom";
            }
        }

        private void cuLogoutButton_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }
    }
}
