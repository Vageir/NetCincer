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

        public AddFood()
        {
            InitializeComponent();
            // TODO: db.ListMenuCategories into fCategoryComboBox
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fAddButton_Click(object sender, EventArgs e)
        {
            Food newFood = new Food();
            newFood.Name = fNameTextBox.Text;
            newFood.Price = Convert.ToInt32(fPriceTextBox.Text);
            newFood.Allergens = fAllergensTextBox.Text;
            string fDescription = fDescriptionRichTextBox.Text;
            newFood.Description = fDescription;
            // TODO: generate random foodID
            //newFood.FoodID = 
            if (fCategoryComboBox.SelectedItem != null)
            {
                newFood.Category = fCategoryComboBox.SelectedItem.ToString();
            }

            db.AddFoods("SADWQE", newFood);
            MessageBox.Show("Új kaja hozzáadva");
        }
    }
}
