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
    public partial class UserDetailsForm : Form
    {
        string name;
        string email;
        string password;
        string confPassword;
        string perfil;
        bool active;

        public UserDetailsForm()
        {
            InitializeComponent();
        }

        //Hide Password Characters
        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.Text = "•";
            tbxPassword.MaxLength = 14;
        }
        private void tbxConfPassword_TextChanged(object sender, EventArgs e)
        {
            tbxConfPassword.Text = "•";
            tbxConfPassword.MaxLength = 14;
        }

        //Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
            if (password == confPassword)
            {
                MessageBox.Show("Salvo com sucesso!");
                CleanData();
            }
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
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            confPassword = tbxConfPassword.Text;
            perfil = cmbProfile.Text;
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
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfPassword.Text = "";
            cmbProfile.Text = "";
            cbxActive.Checked = false;
        }

        //Back Button (User)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm useAll = new UserAllForm();
            useAll.Show();
            this.Close();
        }
    }
}
