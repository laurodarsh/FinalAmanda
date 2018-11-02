using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAmanda.Forms
{
    public partial class ProductDetailsForm : Form
    {
        string name;
        float price;
        string category;
        bool active;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        //Save Button
        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        //Delete Button
        private void pbxDelete_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        //Data stuff
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
        void CleanData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
            cmbCategory.Text = "";
            cbxActive.Checked = false;
        }

        //Back Button (Product)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm();
            product.Show();
            this.Close();
        }
    }
}
