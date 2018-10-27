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
    public partial class UserProfileAllForm : Form
    {
        public UserProfileAllForm()
        {
            InitializeComponent();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            UserProfileDetailsForm details = new UserProfileDetailsForm();
            details.Show();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserProfileDetailsForm details = new UserProfileDetailsForm();
            details.Show();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
        }

        
    }
}
