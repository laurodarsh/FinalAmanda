using FinalAmanda.Classes;
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
    public partial class HomeForm : Form
    {
        User aux;

        public HomeForm(User user)
        {
            InitializeComponent();
            aux = user;
            if (user.Userprofile.Name != "Administrador")
            {
                //"Gerente"
                pbxProductUser.Visible = true;
                lblProductUser.Visible = true;
                pbxCategoryUser.Visible = true;
                lblCategoryUser.Visible = true;
                
                pbxCategory.Visible = false;
                lblCategory.Visible = false;
                pbxLog.Visible = false;
                lblLog.Visible = false;
                pbxUser.Visible = false;
                lblUser.Visible = false;
                pbxProduct.Visible = false;
                lblProduct.Visible = false;
                pbxUserProfile.Visible = false;
                lblUserProfile.Visible = false;
            }
            lblHomeMessage.Text = "Bem vindo " + user.Name + "!";
        }

        //Access only, employee
        private void pbxProductUser_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm(aux);
            product.Show();
            this.Hide();
        }

        private void pbxCategoryUser_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm(aux);
            category.Show();
            this.Hide();
        }
        //End access only, employee

        //Admin access
        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm(aux);
            product.Show();
            this.Hide();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm(aux);
            category.Show();
            this.Hide();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm user = new UserAllForm(aux);
            user.Show();
            this.Hide();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm profile = new UserProfileAllForm(aux);
            profile.Show();
            this.Hide();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm log = new LogForm(aux);
            log.Show();
            this.Hide();
        }

        //Back Button (Login)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginForm2 login = new LoginForm2();
            login.Show();
            this.Hide();
        }
    }
}
