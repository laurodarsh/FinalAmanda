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
    public partial class UserAllForm : Form
    {
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        //Clean Button (eraser)
        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
            ShowData();
            ResizeDataGridView();
        }

        //Search Button
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();

            string optionForm = "UserForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvUser.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
        }

        //Data stuff
        void GetData()
        {
            search = tbxSearch.Text;
        }
        void CleanData()
        {
            tbxSearch.Text = "";
        }

        //Edit and Add things
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            UserDetailsForm userDetails = new UserDetailsForm(idUser);
            userDetails.Show();

            this.Close();
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            //Add
            UserDetailsForm details = new UserDetailsForm();
            details.Show();
        }

        //Trash (delete)
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Usuário inativo!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        //Back Button (Home)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show Data
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].PASSWORD, [USER].EMAIL, [USER].ACTIVE, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE = USER_PROFILE.ID;", sqlConnect);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        //Resize DataGridView
        private void ResizeDataGridView()
        {
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["PASSWORD"].Visible = false;
            dgvUser.Columns["EMAIL"].HeaderText = "E-mail";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvUser.Columns["ACTIVE"].DisplayIndex = 5;
            dgvUser.Columns["NAME1"].HeaderText = "Perfil";
            dgvUser.Columns["NAME1"].DisplayIndex = 4;

            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
    }
}
