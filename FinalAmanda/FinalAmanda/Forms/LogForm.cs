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
    public partial class LogForm : Form
    {
        User aux;
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public LogForm(User user)
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

            string optionForm = "LogForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvLog.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
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

        #region Show Data
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM LOG", sqlConnect);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvLog.DataSource = dt;

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
            dgvLog.Columns["ID"].Visible = false;
            dgvLog.Columns["DESCRIPTION"].HeaderText = "Descrição";
            dgvLog.Columns["DATE"].HeaderText = "Data";
            dgvLog.Columns["TYPE"].HeaderText = "Tipo";

            foreach (DataGridViewColumn col in dgvLog.Columns)
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
