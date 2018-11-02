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

        //Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        //Delete Button
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        //Data stuff
        void GetData()
        {
            name = tbxName.Text;
            if (cbxActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }
        }
        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
        }

        //Back Button (User Profile)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserProfileAllForm profile = new UserProfileAllForm();
            profile.Show();
            this.Close();
        }
    }
}
