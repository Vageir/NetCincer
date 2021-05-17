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
            
            customerCheckedListBox.Items.Clear();
            foreach(var item in menuCategories)
            {
                customerCheckedListBox.Items.Add(item);
            }

            for(int i = 0;i < customerCheckedListBox.Items.Count;i++)
            {
                if (parent.filterCategories.Contains(customerCheckedListBox.Items[i].ToString()))
                {
                    customerCheckedListBox.SetItemChecked(i, true);
                }
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filterStartButton_Click(object sender, EventArgs e)
        {
            //parent.filterCategories.Clear();
            List<string> cats = new List<string>();
            foreach (var item in customerCheckedListBox.CheckedItems)
            {
                cats.Add(Convert.ToString(item));
            }

            parent.setFilterCategories(cats);
            parent.FilterMyListView();
            this.Close();
        }
    }
}
