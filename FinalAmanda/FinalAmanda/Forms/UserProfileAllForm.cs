﻿using System;
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
    public partial class UserProfileAllForm : Form
    {
        string search;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserProfileAllForm()
        {
            InitializeComponent();
        }

        //Clean Button (eraser)
        private void pbxClean_Click(object sender, EventArgs e)
        {
            CleanData();
        }

        //Search Button
        private void pbxSearch_Click(object sender, EventArgs e)
        {
            GetData();
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

        //Edit and Add things
        private void pbxEdit_Click(object sender, EventArgs e)
        {
            //Edit
            UserProfileDetailsForm details = new UserProfileDetailsForm();
            details.Show();
        }
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            //Add
            UserProfileDetailsForm details = new UserProfileDetailsForm();
            details.Show();
        }

        //Trash (delete)
        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }

        //Back Button (Home)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }
    }
}
