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
    public partial class UserProfileDetailsForm : Form
    {
        string name;
        bool active;

        public UserProfileDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm profile = new UserProfileAllForm();
            profile.Show();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        void GetData()
        {
            name = tbxName.Text;
        }

        void CleanData()
        {
            tbxName.Text = "";
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            CleanData();
        }
    }
}
