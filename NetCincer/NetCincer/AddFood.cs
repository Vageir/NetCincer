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
        private List<String> categories;
        private List<Food> foods;
        private Restaurant linRestaurant;

        public AddFood(ref Restaurant rest)
        {
            linRestaurant = rest;
            InitializeComponent();
            InitCategories(linRestaurant.RestaurantID);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        async private void fAddButton_Click(object sender, EventArgs e)
        {
            GetFoods();
            Food newFood = new Food();
            newFood.Name = fNameTextBox.Text;
            newFood.Price = Convert.ToInt32(fPriceTextBox.Text);
            newFood.Allergens = fAllergensTextBox.Text;
            string fDescription = fDescriptionRichTextBox.Text;
            newFood.Description = fDescription;
            newFood.FoodID = GenerateFoodID();
            if (fCategoryComboBox.SelectedItem != null)
            {
                newFood.Category = fCategoryComboBox.SelectedItem.ToString();
            }
            await db.AddFoods(linRestaurant.RestaurantID, newFood);
            MessageBox.Show("Új kaja hozzáadva");
        }

        async private void InitCategories(String RestaurantID)
        {
            categories = await db.ListMenuCategories(linRestaurant.RestaurantID);
            for (int i = 0; i < categories.Count; i++)
            {
                fCategoryComboBox.Items.Add(categories[i]);
            }
        }

        private String GenerateFoodID()
        {
            Boolean found = false;
            int i = -1;
            while (!found)
            {
                i++;
                if (Convert.ToInt32(foods[i].FoodID) != i)
                {
                    found = true;
                }
            }
            return Convert.ToString(i);
        }

        async private void GetFoods()
        {
            foods = await db.ListFoods(linRestaurant.RestaurantID);
        }

    }
}
