using FinalAmanda.Classes;
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
        User user;
        string login;
        string password;
        string email;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public LoginForm()
        {
            InitializeComponent();
        }

        //Login stuff
        private void pbxLogin_Click(object sender, EventArgs e)
        {
            try
            {
                GetData();

                if (CheckLogin(password, login))
                {
                    HomeForm home = new HomeForm(user);
                    home.Show();
                    CleanData();
                    this.Hide();
                }
                else
                {
                    CleanData();
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CleanData();
            }
        }

        private bool CheckLogin(string password, string name)
        {
            user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

        //Data stuff
        void GetData()
        {
            login = tbxUser.Text;
            password = tbxPassword.Text;
        }

        void CleanData()
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
            lblForgotPassword.Visible = false;

            //Visible Forgot Password things
            lblForgotPass.Visible = true;
            lblEmail.Visible = true;
            tbxEmail.Visible = true;
            pbxSend.Visible = true;

        }

        //Send Button
        private void pbxSend_Click(object sender, EventArgs e)
        {
            //GetData Email
            email = tbxEmail.Text;
        }

        //Hehehe :D
        private void pbxLUA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://levelupacademy.com.br/");
        }

    }
}
