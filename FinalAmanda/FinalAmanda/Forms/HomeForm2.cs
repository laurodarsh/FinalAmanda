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
    public partial class HomeForm2 : Form
    {
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public HomeForm2()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginForm2 home = new LoginForm2();
            home.Show();
            this.Hide();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
        }

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

        #region Product

        //Product Button
        private void pnlProduct_MouseClick(object sender, MouseEventArgs e)
        {
            //Hide Itens
            if (lblSearch.Visible == true)
            {
                lblSearch.Visible = false;
                tbxSearch.Visible = false;
                dgvAll.Visible = false;
                pbxAdd.Visible = false;
                pbxSearch.Visible = false;
                pbxClean.Visible = false;
                pbxDelete.Visible = false;
                pbxEdit.Visible = false;
            }
            //Unhide Itens
            else
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
                dgvAll.Visible = true;
                pbxAdd.Visible = true;
                pbxSearch.Visible = true;
                pbxClean.Visible = true;
                pbxDelete.Visible = true;
                pbxEdit.Visible = true;
            }
        }

        #endregion

        #region Category

        //Category Button
        private void pnlCategory_MouseClick(object sender, MouseEventArgs e)
        {
            //Hide Itens
            if (lblSearch.Visible == true)
            {
                lblSearch.Visible = false;
                tbxSearch.Visible = false;
                dgvAll.Visible = false;
                pbxAdd.Visible = false;
                pbxSearch.Visible = false;
                pbxClean.Visible = false;
                pbxDelete.Visible = false;
                pbxEdit.Visible = false;
            }
            //Unhide Itens
            else
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
                dgvAll.Visible = true;
                pbxAdd.Visible = true;
                pbxSearch.Visible = true;
                pbxClean.Visible = true;
                pbxDelete.Visible = true;
                pbxEdit.Visible = true;
            }
        }

        #endregion

        #region User

        //User Button
        private void pnlUser_MouseClick(object sender, MouseEventArgs e)
        {
            //Hide Itens
            if (lblSearch.Visible == true)
            {
                lblSearch.Visible = false;
                tbxSearch.Visible = false;
                dgvAll.Visible = false;
                pbxAdd.Visible = false;
                pbxSearch.Visible = false;
                pbxClean.Visible = false;
                pbxDelete.Visible = false;
                pbxEdit.Visible = false;
            }
            //Unhide Itens
            else
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
                dgvAll.Visible = true;
                pbxAdd.Visible = true;
                pbxSearch.Visible = true;
                pbxClean.Visible = true;
                pbxDelete.Visible = true;
                pbxEdit.Visible = true;
            }
        }

        #endregion

        #region User Profile

        //User Profile Button
        private void pnlUserProfile_MouseClick(object sender, MouseEventArgs e)
        {
            //Hide Itens
            if (lblSearch.Visible == true)
            {
                lblSearch.Visible = false;
                tbxSearch.Visible = false;
                dgvAll.Visible = false;
                pbxAdd.Visible = false;
                pbxSearch.Visible = false;
                pbxClean.Visible = false;
                pbxDelete.Visible = false;
                pbxEdit.Visible = false;
            }
            //Unhide Itens
            else
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
                dgvAll.Visible = true;
                pbxAdd.Visible = true;
                pbxSearch.Visible = true;
                pbxClean.Visible = true;
                pbxDelete.Visible = true;
                pbxEdit.Visible = true;
            }
        }

        #endregion

        #region Log

        //Log Button
        private void pnlLog_MouseClick(object sender, MouseEventArgs e)
        {
            //Hide Itens
            if (lblSearch.Visible == true)
            {
                lblSearch.Visible = false;
                tbxSearch.Visible = false;
                dgvAll.Visible = false;
                pbxAdd.Visible = false;
                pbxSearch.Visible = false;
                pbxClean.Visible = false;
                pbxDelete.Visible = false;
                pbxEdit.Visible = false;
            }
            //Unhide Itens
            else
            {
                lblSearch.Visible = true;
                tbxSearch.Visible = true;
                dgvAll.Visible = true;
                pbxAdd.Visible = true;
                pbxSearch.Visible = true;
                pbxClean.Visible = true;
                pbxDelete.Visible = true;
                pbxEdit.Visible = true;
            }
        }

        #endregion

        private void pbxAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {

        }

        private void pnlProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
