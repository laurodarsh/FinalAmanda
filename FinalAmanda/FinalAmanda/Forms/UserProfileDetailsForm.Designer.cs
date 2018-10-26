namespace FinalAmanda.Forms
{
    partial class UserProfileDetailsForm
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
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive.Location = new System.Drawing.Point(255, 200);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 30;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(201, 196);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(46, 20);
            this.lblActive.TabIndex = 29;
            this.lblActive.Text = "Ativo";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(255, 154);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(127, 28);
            this.tbxName.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(199, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 20);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nome";
            // 
            // pbxDelete
            // 
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Image = global::FinalAmanda.Properties.Resources.Delete;
            this.pbxDelete.Location = new System.Drawing.Point(518, 355);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(72, 69);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelete.TabIndex = 32;
            this.pbxDelete.TabStop = false;
            // 
            // pbxSave
            // 
            this.pbxSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSave.Image = global::FinalAmanda.Properties.Resources.Save;
            this.pbxSave.Location = new System.Drawing.Point(437, 355);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(72, 69);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSave.TabIndex = 31;
            this.pbxSave.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = global::FinalAmanda.Properties.Resources.Back;
            this.pbxBack.Location = new System.Drawing.Point(2, 377);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(53, 48);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 26;
            this.pbxBack.TabStop = false;
            // 
            // UserProfileDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxBack);
            this.Name = "UserProfileDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfileDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}