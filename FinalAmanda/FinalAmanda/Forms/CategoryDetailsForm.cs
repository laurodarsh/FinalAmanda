using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAmanda.Forms
{
    public partial class CategoryDetailsForm : Form
    {
        string name;
        bool active;

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm();
            category.Show();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        void GetData()
        {
            name = tbxName.Text;
        }

        void CleanData()
        {
            tbxName.Text = "";
        }
    }
}
