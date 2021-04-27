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
        FireBaseService db = new FireBaseService();
        public CourierMain(ref Courier cour)
        {
            linCourier = cour;
            InitializeComponent();
            db.changeAvailabity(linCourier.CourierID, false);
        }

        async private void workButton_Click(object sender, EventArgs e)
        {
            if (workButton.Text == "Dolgozom")
            {
                workButton.Text = "Végeztem";
                try
                {
                    await db.changeAvailabity(linCourier.CourierID, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a munka indításában.");
                    workButton.Text = "Dolgozom";
                }
            }
            else
            {
                workButton.Text = "Dolgozom";
                try
                {
                    await db.changeAvailabity(linCourier.CourierID, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a munkából kijelentkezésben.");
                    workButton.Text = "Végeztem";
                }
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
