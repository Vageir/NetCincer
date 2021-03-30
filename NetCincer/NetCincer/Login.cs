using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void lGuestButton_Click(object sender, EventArgs e) // Belepes nelkul tovabb visszuk a felhasznalot a fo oldalra
        {
            Form1 mainWindow = new Form1();
            mainWindow.Show(); // Megnyitjuk a main formot
            this.Hide(); // Azert Hide-ot hasznalunk, mert ez a form kezeli a mukodeset a programnak
        }

        private void lRegistrationButton_Click(object sender, EventArgs e) // Megnyitjuk a regisztracios ablakot popupkent
        {
            Registration regWindow = new Registration();
            regWindow.Show();
        }

        private void lLoginButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
