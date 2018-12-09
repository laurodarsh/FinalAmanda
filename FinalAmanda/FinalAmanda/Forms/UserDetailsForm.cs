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
        User aux;
        string name;
        string email;
        string password;
        string confPassword;
        string perfil;
        bool active;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        List<UserProfile> uprofile = new List<UserProfile>();

        //Save
        public UserDetailsForm(User user)
        {
            InitializeComponent();
            aux = user;
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
            pbxDelete.Visible = false;
        }

        //Edit
        public UserDetailsForm(int idUser, User user2)
        {

            InitializeComponent();
            aux = user2;
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();

            lblId.Text = idUser.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["EMAIL"].ToString();
                            user.Password = reader["PASSWORD"].ToString();
                        }
                    }

                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;


                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao carregar usuário!");
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        #region Load CMB
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
            catch (Exception)
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
        #endregion

        #region Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            //Save
            if (string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    GetData();

                    if (password == confPassword)
                    {
                        UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                        User u = new User(name, password, email, up, active);

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
                        Log.SalvarLog("Usuário inserido", DateTime.Now, "Inserção");
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
            //Edit
            else
            {
                try
                {
                    GetData();

                    UserProfile up = (UserProfile)cmbProfile.SelectedItem;

                    sqlConnect.Open();
                    string sql = "UPDATE [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password,@email, @active, @userprofile) WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@userprofile", up.Id));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SalvarLog("Usuário editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    UserAllForm useAll = new UserAllForm(aux);
                    useAll.Show();
                    this.Close();
                }
            }
        }
        #endregion

        #region Delete Button
        //Used only in Edit
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try

                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuário inativa!");
                    Log.SalvarLog("Usuário excluído", DateTime.Now, "Exclusão");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar esta ususário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }

            }
        }
        #endregion

        #region Data stuff
        //Get
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

        //Clean
        void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxConfPassword.Text = "";
            cmbProfile.Text = "";
            cbxActive.Checked = false;
        }
        #endregion

        #region Back Button User
        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm useAll = new UserAllForm(aux);
            useAll.Show();
            this.Close();
        }
        #endregion
    }
}
