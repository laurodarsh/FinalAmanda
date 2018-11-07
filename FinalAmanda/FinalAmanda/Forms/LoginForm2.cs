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
    public partial class LoginForm2 : Form
    {
        string user;
        string password;
        string email;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public LoginForm2()
        {
            InitializeComponent();

            //User ivisible label
            tbxUser.ForeColor = SystemColors.GrayText;
            tbxUser.Text = "Usuário";
            this.tbxUser.Leave += new System.EventHandler(this.tbxUser_Leave);
            this.tbxUser.Enter += new System.EventHandler(this.tbxUser_Enter);

            //Password ivisible label
            tbxPassword.ForeColor = SystemColors.GrayText;
            tbxPassword.Text = "Senha";
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            
            //Email ivisible label
            tbxEmail.ForeColor = SystemColors.GrayText;
            tbxEmail.Text = "E-mail";
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
        }

        #region User ivisible label

        //Mouse Leave
        private void tbxUser_Leave(object sender, EventArgs e)
        {
            if (tbxUser.Text.Length == 0)
            {
                tbxUser.Text = "Usuário";
                tbxUser.ForeColor = SystemColors.GrayText;
            }
        }

        //Mouse Enter
        private void tbxUser_Enter(object sender, EventArgs e)
        {
            if (tbxUser.Text == "Usuário")
            {
                tbxUser.Text = "";
                tbxUser.ForeColor = SystemColors.WindowText;
            }
        }

        #endregion

        #region Password ivisible label

        //Mouse Leave
        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Length == 0)
            {
                tbxPassword.Text = "Senha";
                tbxPassword.ForeColor = SystemColors.GrayText;
            }
        }

        //Mouse Enter
        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Senha")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = SystemColors.WindowText;
            }
        }

        #endregion

        #region Email ivisible label 

        //Mouse Leave
        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            if (tbxEmail.Text.Length == 0)
            {
                tbxEmail.Text = "E-mail";
                tbxEmail.ForeColor = SystemColors.GrayText;
            }
        }

        //Mouse Enter
        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "E-mail")
            {
                tbxEmail.Text = "";
                tbxEmail.ForeColor = SystemColors.WindowText;
            }
        }

        #endregion

        //Login Button Stuff
        private void pbxLogin_Click(object sender, EventArgs e)
        {
            GetData();
            HomeForm2 home = new HomeForm2();
            home.Show();
            ClenData();
            this.Hide();
        }

        #region Data stuff

        //Get
        void GetData()
        {
            user = tbxUser.Text;
            password = tbxPassword.Text;
        }

        //Clean
        void ClenData()
        {
            tbxUser.Text = "";
            tbxPassword.Text = "";
            tbxEmail.Text = "";
        }

        #endregion

        #region Hide Login

        //Forgot Password Button Click
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //Hide Login things
            this.pnlHide.Location = new Point(pnlHide.Location.X + 340, pnlHide.Location.Y + 0);
            this.pnlHide.BackColor = Color.DarkViolet;
        }

        #endregion

        //Send Button
        private void pbxSend_Click(object sender, EventArgs e)
        {
            //GetData Email
            email = tbxEmail.Text;

            tbxEmail.Visible = false;
            lblEmail.Text = "Um e-mail foi enviado para o endereço " + Environment.NewLine + "...." + Environment.NewLine + "  Siga as instruções para redefinir sua " + Environment.NewLine + "senha.";
        }

        #region Eye Mouse Move
        //Mouse Enter
        private void pbxEye_MouseEnter(object sender, EventArgs e)
        {
            this.pbxEye.BackColor = Color.LightGray;
        }

        //Mouse Leave
        private void pbxEye_MouseLeave(object sender, EventArgs e)
        {
            this.pbxEye.BackColor = Color.White;
        }
        #endregion
        
        #region Hide Password Button
        private void pbxEye_Click(object sender, EventArgs e)
        { 
            
            if (tbxPassword.UseSystemPasswordChar == true)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;

            }
        }
        #endregion
    }
}
