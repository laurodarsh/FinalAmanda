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
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pbxSend = new System.Windows.Forms.PictureBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(205, 124);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(63, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuário";
            // 
            // tbxUser
            // 
            this.tbxUser.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUser.Location = new System.Drawing.Point(207, 142);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(181, 26);
            this.tbxUser.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(208, 197);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPassword.Size = new System.Drawing.Size(181, 26);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(206, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Indigo;
            this.lblForgotPassword.Location = new System.Drawing.Point(207, 226);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(121, 15);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Esqueceu sua senha?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.Indigo;
            this.lblForgotPass.Location = new System.Drawing.Point(175, 123);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(242, 28);
            this.lblForgotPass.TabIndex = 7;
            this.lblForgotPass.Text = "Esqueceu a sua senha?";
            this.lblForgotPass.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(178, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(123, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Digite seu e-mail";
            this.lblEmail.Visible = false;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(181, 188);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(236, 26);
            this.tbxEmail.TabIndex = 9;
            this.tbxEmail.Visible = false;
            // 
            // pbxSend
            // 
            this.pbxSend.BackColor = System.Drawing.Color.Transparent;
            this.pbxSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSend.Image = global::FinalAmanda.Properties.Resources.Send;
            this.pbxSend.Location = new System.Drawing.Point(317, 263);
            this.pbxSend.Name = "pbxSend";
            this.pbxSend.Size = new System.Drawing.Size(100, 29);
            this.pbxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSend.TabIndex = 10;
            this.pbxSend.TabStop = false;
            this.pbxSend.Visible = false;
            this.pbxSend.Click += new System.EventHandler(this.pbxSend_Click);
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
            this.pbxLogin.Click += new System.EventHandler(this.pbxLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.pbxSend);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.lblUser);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).EndInit();
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
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.PictureBox pbxSend;
    }
}