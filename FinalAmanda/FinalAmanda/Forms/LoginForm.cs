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
    public partial class LoginForm : Form
    {
        string user;
        string password;
        string email;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void pbxLogin_Click(object sender, EventArgs e)
        {
            GetData();
            HomeForm home = new HomeForm();
            home.Show();
            ClenData();
        }

        void GetData()
        {
            user = tbxUser.Text;
            password = tbxPassword.Text;
        }

        void ClenData()
        {
            tbxUser.Text = "";
            tbxPassword.Text = "";
            tbxEmail.Text = "";
        }

        //Forgot Password things
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //Invisible Login things
                lblUser.Visible = false;
                tbxPassword.Visible = false;
                lblPassword.Visible = false;
                tbxPassword.Visible = false;
                pbxLogin.Visible = false;
            
            //Visible Forgot Password things
            lblForgotPass.Visible = true;
            lblEmail.Visible = true;
            tbxEmail.Visible = true;
            pbxSend.Visible = true;
            
        }

        private void pbxSend_Click(object sender, EventArgs e)
        {
            //GetData Email
            email = tbxEmail.Text;
        }
    }
}
