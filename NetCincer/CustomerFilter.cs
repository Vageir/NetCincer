using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace NetCincer
{
    public partial class CustomerFilter : Form
    {
        FireBaseService fb = new FireBaseService();
        List<string> menuCategories;
        private CustomerMain parent;
        public CustomerFilter(CustomerMain parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void CustomerFilter_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        async private void loadCategories()
        {
            
            menuCategories = await fb.ListMenuCategoriesName(parent.restaurantName);
            MessageBox.Show(menuCategories.Count.ToString());
            customerCheckedListBox.Items.Clear();
            foreach(var item in menuCategories)
            {
                customerCheckedListBox.Items.Add(item);
            }
            
        }
    }
}
