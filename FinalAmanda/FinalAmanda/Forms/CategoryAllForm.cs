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
    public partial class CategoryAllForm : Form
    {
        string search;

        public CategoryAllForm()
        {
            InitializeComponent();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm details = new CategoryDetailsForm();
            details.Show();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm details = new CategoryDetailsForm();
            details.Show();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        void GetData()
        {
            search = tbxSearch.Text;
        }

        void CleanData()
        {
            tbxSearch.Text = "";
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
