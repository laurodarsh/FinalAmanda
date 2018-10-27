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
        bool active;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm();
            product.Show();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        void GetData()
        {
            name = tbxName.Text;
            price = float.Parse(tbxPrice.Text);
        }

        void CleanData()
        {
            tbxName.Text = "";
            tbxPrice.Text = "";
        }
    }
}
