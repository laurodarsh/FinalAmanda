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
    public partial class ProductDetailsForm : Form
    {
        User aux;
        string name = "";
        float price = 0;
        string category = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        List<Category> categories = new List<Category>();

        //Save
        public ProductDetailsForm(User user)
        {
            InitializeComponent();
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();
            aux = user;
            pbxDelete.Visible = false;
        }

        //Edit
        public ProductDetailsForm(int idProduct, User user)
        {

            InitializeComponent();
            aux = user;
            cmbCategory.DisplayMember = "NAME";
            LoadComboBox();

            lblId.Text = idProduct.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblId.Text))
            {
                try
                {
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT WHERE ID = @id", sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", idProduct));

                    Product product = new Product();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.Id = Int32.Parse(reader["ID"].ToString());
                            product.Name = reader["NAME"].ToString();
                            product.Active = bool.Parse(reader["ACTIVE"].ToString());
                            product.Price = float.Parse(reader["PRICE"].ToString());
                        }
                    }

                    tbxName.Text = product.Name;
                    cbxActive.Checked = product.Active;
                    tbxPrice.Text = product.Price.ToString();


                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao carregar produto!");
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
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    categories.Add(c);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (Category c in categories)
            {
                cmbCategory.Items.Add(c);
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

                    Category c = (Category)cmbCategory.SelectedItem;
                    Product p = new Product(name, active, c, price);

                    sqlConnect.Open();
                    string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", p.Name));
                    cmd.Parameters.Add(new SqlParameter("@price", p.Price));
                    cmd.Parameters.Add(new SqlParameter("@active", p.Active));
                    cmd.Parameters.Add(new SqlParameter("@category", p.Category.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog(sqlConnect,"Produto inserido", DateTime.Now, "Inserção");
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

                    Category c = (Category)cmbCategory.SelectedItem;

                    sqlConnect.Open();
                    string sql = "UPDATE PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category) WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@price", price));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@category", c.Id));
                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SaveLog(sqlConnect,"Produto editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    ProductAllForm product = new ProductAllForm(aux);
                    product.Show();
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
                    string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblId.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto inativa!");
                    Log.SaveLog(sqlConnect,"Produto excluído", DateTime.Now, "Exclusão");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar esta produto!" + "\n\n" + Ex.Message);
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
            price = float.Parse(tbxPrice.Text);
            category = cmbCategory.Text;
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
            tbxPrice.Text = "";
            cmbCategory.Text = "";
            cbxActive.Checked = false;
        }
        #endregion

        #region Back Button Product
        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm(aux);
            product.Show();
            this.Close();
        }
        #endregion
    }
}
