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
    public partial class CategoryDetailsForm : Form
    {
        string name;
        bool active;

        public CategoryDetailsForm()
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
            cbxActive. Checked = false;
        }

        //Back Button (Categoty)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm();
            category.Show();
            this.Close();
        }
    }
}
