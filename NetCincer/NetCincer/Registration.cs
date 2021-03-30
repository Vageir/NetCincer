using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace NetCincer
{
    public partial class Registration : Form
    {
        private Login storedParent;
        public Registration()
        {
            
            InitializeComponent();
        }

        ~Registration()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Login);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void setParent(ref Login _parent)
        {
            storedParent = _parent;
        }
    }
}
