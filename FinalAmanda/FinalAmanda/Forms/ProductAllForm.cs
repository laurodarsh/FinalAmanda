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
    public partial class ProductAllForm : Form
    {
        User aux;
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public ProductAllForm(User user)
        {
            InitializeComponent();
            aux = user;
            ShowData();
            ResizeDataGridView();
        }

        #region Clean Button (eraser)
        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
            ShowData();
            ResizeDataGridView();
        }
        #endregion

        #region Search Button
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();

            string optionForm = "ProductForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvProduct.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
        }
        #endregion

        #region Data stuff
        //Get
        void GetData()
        {
            search = tbxSearch.Text;
        }

        //Clean
        void CleanData()
        {
            tbxSearch.Text = "";
        }
        #endregion

        #region Edit Stuff
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            ProductDetailsForm productDetails = new ProductDetailsForm(idProduct, aux);
            productDetails.Show();

            this.Close();
        }
        #endregion

        #region Add Stuff
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            ProductDetailsForm details = new ProductDetailsForm(aux);
            details.Show();

            this.Close();
        }
        #endregion

        #region Trash (delete)
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idProduct));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Produto inativo!");
                Log.SaveLog(sqlConnect,"Produto excluído", DateTime.Now, "Exclusão");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        #endregion

        #region Show Data
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd;
                sqlConnect.Open();

                if (aux.Userprofile.Name != "Administrador")
                {
                    cmd = new SqlCommand("SELECT PRODUCT.ID, PRODUCT.NAME, PRODUCT.ACTIVE, PRODUCT.PRICE, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY ON PRODUCT.FK_PRODUCT = CATEGORY.ID; WHERE PRODUCT.ACTIVE = @active", sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@active", true));
                }
                else
                {
                    cmd = new SqlCommand("SELECT PRODUCT.ID, PRODUCT.NAME, PRODUCT.ACTIVE, PRODUCT.PRICE, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY ON PRODUCT.FK_PRODUCT = CATEGORY.ID;", sqlConnect);
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvProduct.DataSource = dt;

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
        #endregion

        #region Resize Data Grid View
        private void ResizeDataGridView()
        {
            dgvProduct.Columns["ID"].Visible = false;
            dgvProduct.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvProduct.Columns["ACTIVE"].DisplayIndex = 4;
            dgvProduct.Columns["NAME1"].HeaderText = "Categoria";
            dgvProduct.Columns["NAME1"].DisplayIndex = 3;
            dgvProduct.Columns["PRICE"].HeaderText = "Preço";
            dgvProduct.Columns["NAME"].HeaderText = "Nome";

            foreach (DataGridViewColumn col in dgvProduct.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        #endregion

        #region Back Button (Home)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(aux);
            home.Show();
            this.Close();
        }
        #endregion
    }
}
