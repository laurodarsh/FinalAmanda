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
    public partial class UserProfileDetailsForm : Form
    {
        string name;
        bool active;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserProfileDetailsForm()
        {
            InitializeComponent();

        }

        public UserProfileDetailsForm(int idUProfile)
        {

            InitializeComponent();

            lblId.Text = idUProfile.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUProfile));

                    UserProfile userProfile = new UserProfile();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userProfile.Id = Int32.Parse(reader["ID"].ToString());
                            userProfile.Name = reader["NAME"].ToString();
                            userProfile.Active = bool.Parse(reader["ACTIVE"].ToString());





                        }
                    }

                    tbxName.Text = userProfile.Name;
                    cbxActive.Checked = userProfile.Active;


                }
                catch (Exception EX)
                {
                    MessageBox.Show("Erro ao carregar perfil!");
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        //Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();

                UserProfile up = new UserProfile(name, active);

                sqlConnect.Open();
                string sql = "INSERT INTO USER_PROFILE(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", up.Name));
                cmd.Parameters.Add(new SqlParameter("@active", up.Active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar perfil!" + ex.Message);
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
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try

                {
                    sqlConnect.Open();
                    string sql = "UPDATE USER_PRODILE SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Perfil inativa!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar esta perfil!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }

            }
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
