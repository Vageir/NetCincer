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

            if (checkCustomerFields())
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
                    //MessageBox.Show("Sikeres regisztráció!", "Infó");
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

        private bool checkCustomerFields()
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

        private bool checkRestaurantFields()
        {
            if (
                rUsername.Text == "" ||
                rName.Text == "" ||
                rPassword.Text == "" ||
                rOpening.Text == "" || // Formatum ellenorzes kell!
                rClosing.Text == "" || // Formatum ellenorzes kell!
                rDeliveryTime.Text == "" ||
                rCity.Text == "" ||
                rStreet.Text == "" ||
                rHouseNumber.Text == "")
            {
                return false;
            }
            return true;
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            if (checkRestaurantFields())
            {
                Restaurant newRestaurant = await db.GetRestaurant(rUsername.Text);
                if (newRestaurant == null)
                {
                    newRestaurant = new Restaurant();
                    newRestaurant.RestaurantID = rUsername.Text;
                    newRestaurant.RestaurantName = rName.Text;
                    newRestaurant.Password = rPassword.Text;
                    newRestaurant.OpenTime = rOpening.Text;
                    newRestaurant.CloseTime = rClosing.Text;
                    newRestaurant.DeliveryTime = Convert.ToInt32(rDeliveryTime.Text);

                    Location newLocation = new Location();
                    newLocation.City = rCity.Text;
                    newLocation.Street = rStreet.Text;
                    newLocation.HouseNumber = Convert.ToInt32(rHouseNumber.Text);

                    newRestaurant.Address = newLocation;

                    await db.AddRestaurant(newRestaurant);
                    //MessageBox.Show("Sikeres regisztráció!", "Infó");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A felhasználónév foglalt!", "Infó");
                }
            }
            else
            {
                MessageBox.Show("Kérem tölsön ki minden mezőt!", "Infó");
            }
        }

        private bool checkCourierFields() {
            if (
                cuUsername.Text == "" ||
                cuName.Text == "" ||
                cuPassword.Text == "" ||
                cuNumber.Text == "" 
                ) {
                return false;
            }
            else {
                return true;
            }
        }

        async private void button3_Click(object sender, EventArgs e)
        {
            if (checkCourierFields())
            {
                Courier newCourier = await db.GetCourier(cuName.Text);
                if (newCourier == null)
                {
                    newCourier = new Courier();
                    newCourier.CourierID = cuUsername.Text;
                    newCourier.Name = cuName.Text;
                    newCourier.Password = cuPassword.Text;
                    newCourier.PhoneNumber = cuNumber.Text;

                    await db.AddCourier(newCourier);
                    //MessageBox.Show("Sikeres regisztráció!", "Infó");
                    this.Close();
                }
                else {
                    MessageBox.Show("A felhasználónév foglalt!", "Infó");
                }
            }
            else {
                MessageBox.Show("Kérem tölsön ki minden mezőt!", "Infó");
            }
        }
    }
}
