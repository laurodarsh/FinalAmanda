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
        public HomeForm(User user)
        {
            InitializeComponent();
            if (user.Userprofile.Name != "Gerente")
            {
                pbxProductUser.Visible = true;
                pbxCategoryUser.Visible = true;

                pbxCategory.Visible = false;
                pbxLog.Visible = false;
                pbxUser.Visible = false;
                pbxProduct.Visible = false;
                pbxUserProfile.Visible = false;
            }
        }

        //Access only, employee
        private void pbxProductUser_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm();
            product.Show();
            this.Hide();
        }

        private void pbxCategoryUser_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm();
            category.Show();
            this.Hide();
        }
        //End access only, employee

        //Admin access
        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm product = new ProductAllForm();
            product.Show();
            this.Hide();
        }
        
        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm category = new CategoryAllForm();
            category.Show();
            this.Hide();
        }
        
        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm user = new UserAllForm();
            user.Show();
            this.Hide();
        }

        private void pbxUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm profile = new UserProfileAllForm();
            profile.Show();
            this.Hide();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm log = new LogForm();
            log.Show();
            this.Hide();
        }

        //Back Button (Login)
        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
