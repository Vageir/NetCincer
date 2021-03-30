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
        FireBaseService loginer = new FireBaseService();
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

        async private void lLoginButton_Click(object sender, EventArgs e)
        {
            Customer passChecker = new Customer();
            if (lUsernameTextBox.Text != "" && lPasswordTextBox.Text != "")
            {
                passChecker = await loginer.GetCustomer(lUsernameTextBox.Text);
                if (passChecker != null && passChecker.Password == lPasswordTextBox.Text)
                {
                    MessageBox.Show("Sikeres bejelentkezés!", "Infó");
                    // TODO: Átvitel fő felületre
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Infó");
                }
            }
            else
            {
                MessageBox.Show("Kérem minden mezőt töltsön ki.", "Infó");
            }
            
        }
    }
}
