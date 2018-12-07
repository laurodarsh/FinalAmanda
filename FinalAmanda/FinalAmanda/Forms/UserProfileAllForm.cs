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
    public partial class UserProfileAllForm : Form
    {
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserProfileAllForm()
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

            string optionForm = "UserProfileForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvUProfile.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
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
            int idUProfile = Int32.Parse(dgvUProfile.SelectedRows[0].Cells[0].Value.ToString());

            UserProfileDetailsForm uProfileDetails = new UserProfileDetailsForm(idUProfile);
            uProfileDetails.Show();

            this.Close();
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            //Add
            UserProfileDetailsForm details = new UserProfileDetailsForm();
            details.Show();
        }

        //Trash (delete)
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUProfile = Int32.Parse(dgvUProfile.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE USER_PROFILE SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUProfile));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Perfil inativo!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este perfil!" + "\n\n" + Ex.Message);
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUProfile.DataSource = dt;

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
            dgvUProfile.Columns["ID"].Visible = false;
            dgvUProfile.Columns["NAME"].HeaderText = "Nome";
            dgvUProfile.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvUProfile.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
    }
}
