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
            Customer cust = new Customer();
            CustomerMain mainWindow = new CustomerMain(ref cust);
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
            
            if (lUsernameTextBox.Text != "" && lPasswordTextBox.Text != "")
            {
                customerLogin();
            }
            else
            {
                MessageBox.Show("Kérem minden mezőt töltsön ki.", "Infó");
            }
            
        }

        async private void customerLogin()
        {
            Customer passChecker = new Customer();
            passChecker = await loginer.GetCustomer(lUsernameTextBox.Text);
            if (passChecker != null && passChecker.Password == lPasswordTextBox.Text)
            {
                //MessageBox.Show("Sikeres bejelentkezés!", "Infó");
                this.Hide();
                CustomerMain main = new CustomerMain(ref passChecker);
                main.Show();
                // TODO: Átvitel fő felületre
            }
            else
            {
                restaurantLogin();
            }
        }

        async private void restaurantLogin()
        {
            Restaurant passChecker = new Restaurant();
            passChecker = await loginer.GetRestaurant(lUsernameTextBox.Text);
            if (passChecker != null && passChecker.Password == lPasswordTextBox.Text)
            {
                //MessageBox.Show("Sikeres bejelentkezés!\nID: " + passChecker.RestaurantID, "Infó");
                this.Hide();
                RestaurantFoodListing main = new RestaurantFoodListing(ref passChecker);
                main.Show();
                // TODO: Átvitel fő felületre
            }
            else
            {
                courierLogin();
            }
        }

        async private void courierLogin()
        {
            Courier passChecker = new Courier();
            passChecker = await loginer.GetCourier(lUsernameTextBox.Text);
            if (passChecker != null && passChecker.Password == lPasswordTextBox.Text)
            {
                //MessageBox.Show("Sikeres bejelentkezés!", "Infó");
                this.Hide();
                CourierMain main = new CourierMain(ref passChecker);
                main.Show();
                // TODO: Átvitel fő felületre
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Infó");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
