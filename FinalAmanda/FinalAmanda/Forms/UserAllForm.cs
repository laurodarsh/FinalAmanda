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
    public partial class UserAllForm : Form
    {
        string search;

        public UserAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserDetailsForm details = new UserDetailsForm();
            details.Show();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserDetailsForm details = new UserDetailsForm();
            details.Show();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        void GetData()
        {
            search = tbxSearch.Text;
        }

        void CleanData()
        {
            tbxSearch.Text = "";
        }
    }
}
