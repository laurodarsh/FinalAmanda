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
    public partial class CategoryAllForm : Form
    {
        User aux;
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategoryAllForm(User user)
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

            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search2 = new Search();
            dgvCategory.DataSource = search2.SearchFilter(connectionString, search, optionString, optionForm);
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
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory,aux);
            categoryDetails.Show();

            this.Close();
        }
        #endregion

        #region Add Stuff
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm details = new CategoryDetailsForm(aux);
            details.Show();

            this.Close();
        }
        #endregion

        #region Trash (delete)
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
                Log.SaveLog(sqlConnect,"Categoria excluída", DateTime.Now,"Exclusão");
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
                    cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ACTIVE = @active", sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@active", true));
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);
                }

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
        #endregion

        #region Resize Dat Grid View
        private void ResizeDataGridView()
        {
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Corbel", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
        #endregion
        
        #region Back Button Home
        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm(aux);
            home.Show();
            this.Close();
        }
        #endregion
    }
}
