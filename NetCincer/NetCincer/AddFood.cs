using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class AddFood : Form
    {

        FireBaseService db = new FireBaseService();
        List<String> categories;

        public AddFood()
        {
            InitializeComponent();
            // TODO: use id of logged in restaurant
            InitCategories("SADWQE");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        async private void fAddButton_Click(object sender, EventArgs e)
        {
            Food newFood = new Food();
            newFood.Name = fNameTextBox.Text;
            newFood.Price = Convert.ToInt32(fPriceTextBox.Text);
            newFood.Allergens = fAllergensTextBox.Text;
            string fDescription = fDescriptionRichTextBox.Text;
            newFood.Description = fDescription;
            // TODO: generate random foodID
            newFood.FoodID = GenerateFoodID();
            if (fCategoryComboBox.SelectedItem != null)
            {
                newFood.Category = fCategoryComboBox.SelectedItem.ToString();
            }
            // TODO: use id of logged in restaurant
            await db.AddFoods("SADWQE", newFood);
            MessageBox.Show("Új kaja hozzáadva");
        }

        async private void InitCategories(String RestaurantID)
        {
            // TODO: use id of logged in restaurant
            categories = await db.ListMenuCategories("SADWQE");
            for (int i = 0; i < categories.Count; i++)
            {
                fCategoryComboBox.Items.Add(categories[i]);
            }
        }

        /*async*/
        private String GenerateFoodID()
        {
            String id = "kaga";
            //List<Food> ids = await db.ListFoods("SADWQE");
            return id;
        }
    }
}
