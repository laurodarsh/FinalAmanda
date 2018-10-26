namespace FinalAmanda.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(205, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 18);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuário";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(207, 142);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(181, 28);
            this.tbxUser.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(208, 197);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPassword.Size = new System.Drawing.Size(181, 28);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(207, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblForgotPassword.Location = new System.Drawing.Point(207, 228);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(108, 17);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Esqueceu a senha?";
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogin.Image = global::FinalAmanda.Properties.Resources.Enter1;
            this.pbxLogin.Location = new System.Drawing.Point(292, 263);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(100, 29);
            this.pbxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogin.TabIndex = 6;
            this.pbxLogin.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.lblUser);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.PictureBox pbxLogin;
    }
}