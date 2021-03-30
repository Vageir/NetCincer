using System;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class Registration : Form
    {
        FireBaseService db = new FireBaseService();
        public Registration()
        {
            InitializeComponent();
        }

        async private void cRegistrationButton_Click(object sender, EventArgs e)
        {

            if (checkFields())
            {
                Customer newCustomer = await db.GetCustomer(cUsername.Text);
                if (newCustomer == null)
                {
                    newCustomer = new Customer();
                    newCustomer.CustomerID = cUsername.Text;
                    newCustomer.Name = cName.Text;
                    newCustomer.Password = cPassword.Text;
                    newCustomer.PhoneNumber = cNumber.Text;

                    Location newLocation = new Location();
                    newLocation.City = cCity.Text;
                    newLocation.Street = cStreet.Text;
                    newLocation.HouseNumber = Convert.ToInt32(cHouseNumber.Text);

                    newCustomer.Address = newLocation;

                    await db.AddCustomer(newCustomer);
                    MessageBox.Show("Sikeres regisztráció!", "Infó");
                    this.Close();
                } else
                {
                    MessageBox.Show("A felhasználónév foglalt!", "Infó");
                }
                
                

                
            } else
            {
                MessageBox.Show("Kérem tölsön ki minden mezőt!", "Infó");
            }
        }

        private bool checkFields()
        {
            if (
                cUsername.Text == "" ||
                cName.Text == "" ||
                cPassword.Text == "" ||
                cNumber.Text == "" ||
                cCity.Text == "" ||
                cStreet.Text == "" ||
                cHouseNumber.Text == "")
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
