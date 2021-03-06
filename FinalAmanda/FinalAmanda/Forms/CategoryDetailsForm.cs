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
    public partial class CategoryDetailsForm : Form
    {
        User aux;
        string name = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        //Save
        public CategoryDetailsForm(User user)
        {
            InitializeComponent();
            aux = user;
            pbxDelete.Visible = false;
        }

        //Edit
        public CategoryDetailsForm(int idCategory, User user)
        {

            InitializeComponent();
            aux = user;

            lblId.Text = idCategory.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idCategory));

                    Category category = new Category();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            category.Id = Int32.Parse(reader["ID"].ToString());
                            category.Name = reader["NAME"].ToString();
                            category.Active = bool.Parse(reader["ACTIVE"].ToString());





                        }
                    }

                    tbxName.Text = category.Name;
                    cbxActive.Checked = category.Active;


                }
                catch (Exception EX)
                {
                    MessageBox.Show("Erro ao carregar categoria!");
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

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

                    Category c = new Category(name, active);

                    sqlConnect.Open();
                    string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (@name, @active)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", c.Name));
                    cmd.Parameters.Add(new SqlParameter("@active", c.Active));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog(sqlConnect,"Categoria inserida", DateTime.Now, "Inserção");
                    CleanData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
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

                    sqlConnect.Open();
                    string sql = "UPDATE CATEGORY(NAME, ACTIVE) VALUES (@name, @active) WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SaveLog(sqlConnect,"Categoria editada", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar esta categoria!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    CategoryAllForm category = new CategoryAllForm(aux);
                    category.Show();
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
                    string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("categoria inativa!");
                    Log.SaveLog(sqlConnect,"Categoria excluída", DateTime.Now, "Exclusão");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar esta categoria!" + "\n\n" + Ex.Message);
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
            cbxActive.Checked = false;
        }
        #endregion

        #region Back Button Categoty
        private void pbxBack_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm(aux);
            category.Show();
            this.Close();
        }
        #endregion
    }
}
