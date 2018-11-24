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
    public partial class CategoryAllForm : Form
    {
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategoryAllForm()
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

            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvCategory.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
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

        //Edit
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory);
            categoryDetails.Show();

            this.Close();
        }
        //Add
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm details = new CategoryDetailsForm();
            details.Show();
            this.Close();
        }

        //Trash (delete)
        private void pbxDelete_Click(object sender, EventArgs e)
        {

            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Categoria inativo!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este categoria!" + "\n\n" + Ex.Message);
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
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }

        //Show Data
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

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

        private void ResizeDataGridView()
        {
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
    }
}
