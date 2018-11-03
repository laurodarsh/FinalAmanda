using FinalAmanda.Classes;
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
    public partial class UserDetailsForm : Form
    {
        string name;
        string email;
        string password;
        string confPassword;
        string perfil;
        bool active;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        List<UserProfile> uprofile = new List<UserProfile>();

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        //Load CMB
        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile up = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    uprofile.Add(up);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile c in uprofile)
            {
                cmbProfile.Items.Add(c);
            }
        }
        
        //Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                if (password == confPassword)
                {
                    UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                    User u = new User(name,password,email,up,active);

                    sqlConnect.Open();
                    string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password,@email, @active, @userprofile)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", u.Name));
                    cmd.Parameters.Add(new SqlParameter("@password", u.Password));
                    cmd.Parameters.Add(new SqlParameter("@email", u.Email));
                    cmd.Parameters.Add(new SqlParameter("@active", u.Active));
                    cmd.Parameters.Add(new SqlParameter("@userprofile", u.Userprofile.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    CleanData();
                }
                else
                {
                    MessageBox.Show("Confirmação de senha incorreta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usuário!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();

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
