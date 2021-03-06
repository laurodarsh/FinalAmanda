﻿using FinalAmanda.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAmanda.Forms
{
    public partial class LoginForm2 : Form
    {
        User user;
        string login = "";
        string password = "";
        string email = "";
        bool updated = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public LoginForm2()
        {
            InitializeComponent();

            //User ivisible label
            tbxUser.ForeColor = Color.Silver;
            tbxUser.Text = "Usuário";
            this.tbxUser.Leave += new System.EventHandler(this.tbxUser_Leave);
            this.tbxUser.Enter += new System.EventHandler(this.tbxUser_Enter);

            //Password ivisible label
            tbxPassword.ForeColor = Color.Silver;
            tbxPassword.Text = "Senha";
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);

            //Email ivisible label
            tbxEmail.ForeColor = Color.Silver;
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
                tbxUser.ForeColor = Color.Silver;
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
                tbxPassword.ForeColor = Color.Silver;
                //tbxPassword.PasswordChar = '\0';
                tbxPassword.UseSystemPasswordChar = false;
            }
        }

        //Mouse Enter
        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "Senha")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.Black;
                //tbxPassword.PasswordChar = '*';
                tbxPassword.UseSystemPasswordChar = true;
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
                tbxEmail.ForeColor = Color.Silver;
            }
        }

        //Mouse Enter
        private void tbxEmail_Enter(object sender, EventArgs e)
        {
            if (tbxEmail.Text == "E-mail")
            {
                tbxEmail.Text = "";
                tbxEmail.ForeColor = Color.Black;
            }
        }

        #endregion

        #region Login Stuff

        //Login Button Stuff
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

        //Check Login
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
        #endregion

        #region Data stuff

        //Get
        void GetData()
        {
            login = tbxUser.Text;
            password = tbxPassword.Text;
        }

        //Clean
        void CleanData()
        {
            tbxUser.Text = "";
            tbxPassword.Text = "";
            tbxEmail.Text = "";
        }

        #endregion

        #region Hide Login

        //Forgot Password Label Click
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //Hide Login things
            this.pnlHide.Location = new Point(pnlHide.Location.X + 353, pnlHide.Location.Y + 0);
            this.pnlHide.BackColor = Color.Salmon;

            //Logo
            pbxLua2.Visible = true;
            pbxLua.Visible = false;
        }

        #endregion

        #region Send Email
        //Send Button
        private void pbxSend_Click(object sender, EventArgs e)
        {
            //GetData Email
            email = tbxEmail.Text;

            pbxSend.Visible = false;
            pbxOkay.Visible = true;
            lblBackLogin.Visible = false;
            tbxEmail.Visible = false;

            if (tbxEmail.Text.Length > 0)
            {
                UpdatePassword();
                if (updated)
                {
                    this.Close();
                }
            }
        }

        //Back Login
        private void pbxOkay_Click(object sender, EventArgs e)
        {
            CleanData();

            pbxSend.Visible = true;
            pbxOkay.Visible = false;
            lblBackLogin.Visible = true;
            tbxEmail.Visible = true;
            lblEmail.Text = "Digite seu e-mail";

            //Logo
            pbxLua2.Visible = false;
            pbxLua.Visible = true;

            //Hide Forgot Password things
            this.pnlHide.Location = new Point(pnlHide.Location.X - 353, pnlHide.Location.Y - 0);
            this.pnlHide.BackColor = Color.White;
        }
        
        //Update Password
        void UpdatePassword()
        {
            User user = UserHelper.SelectByName(tbxEmail.Text);

            if (user.Name == null)
            {
                MessageBox.Show("Email não encontrado");
                updated = false;
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                Random rnd = new Random();
                int randowmPassword = rnd.Next(1, 1000);

                try
                {
                    EmailHelper.SendEmail(user.Email, randowmPassword);

                    GetData();
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET PASSWORD = @password Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash(randowmPassword.ToString())));

                    cmd.Parameters.Add(new SqlParameter("@id", user.Id));
                    cmd.ExecuteNonQuery();

                    lblEmail.Text = "Um e-mail foi enviado para o endereço " + Environment.NewLine + email + "." + Environment.NewLine + "  Siga as instruções para redefinir sua " + Environment.NewLine + "senha.";
                    Log.SaveLog(sqlConnect,"Usuário Editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao enviar nova senha!" + "\n\n" + Ex.Message);
                    updated = false;
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

#endregion

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

        #region Eye Hide Password Button

        //Hide and Unhide Password
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

        #region Forgot Password Label

        //Mouse Enter
        private void lblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font.Name, lblForgotPassword.Font.SizeInPoints, FontStyle.Underline);
        }

        //Mouse Leave
        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.Font = new Font(lblForgotPassword.Font.Name, lblForgotPassword.Font.SizeInPoints, FontStyle.Regular);
        }
        #endregion

        #region Hide Forgot Password

        //Back Login Button Click
        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            //Clean tbxEmail
            tbxEmail.Text = "";

            //Hide Forgot Password things
            this.pnlHide.Location = new Point(pnlHide.Location.X - 353, pnlHide.Location.Y - 0);
            this.pnlHide.BackColor = Color.White;

            //Logo
            pbxLua2.Visible = false;
            pbxLua.Visible = true;
        }

        #endregion

        #region Back Login Label

        //Mouse Enter
        private void lblBackLogin_MouseEnter(object sender, EventArgs e)
        {
            lblBackLogin.Font = new Font(lblBackLogin.Font.Name, lblBackLogin.Font.SizeInPoints, FontStyle.Underline);
        }

        //Mouse Leave
        private void lblBackLogin_MouseLeave(object sender, EventArgs e)
        {
            lblBackLogin.Font = new Font(lblBackLogin.Font.Name, lblBackLogin.Font.SizeInPoints, FontStyle.Regular);
        }

        #endregion

        #region Idea of Genius

        //Hehehe :D
        private void pbxLua2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://levelupacademy.com.br/");
        }

        private void pbxLua_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://levelupacademy.com.br/");
        }

        #endregion

        #region Toolbar

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

    }
}
