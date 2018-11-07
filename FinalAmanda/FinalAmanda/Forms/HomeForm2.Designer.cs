namespace FinalAmanda.Forms
{
    partial class HomeForm2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlUserProfile = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pbxAdd);
            this.panel1.Controls.Add(this.pbxDelete);
            this.panel1.Controls.Add(this.pbxEdit);
            this.panel1.Controls.Add(this.dgvAll);
            this.panel1.Controls.Add(this.pbxClean);
            this.panel1.Controls.Add(this.pbxSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.tbxSearch);
            this.panel1.Controls.Add(this.pnlLog);
            this.panel1.Location = new System.Drawing.Point(55, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 482);
            this.panel1.TabIndex = 0;
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = global::FinalAmanda.Properties.Resources.Add;
            this.pbxAdd.Location = new System.Drawing.Point(720, 431);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(53, 48);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 46;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Visible = false;
            // 
            // pbxDelete
            // 
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Image = global::FinalAmanda.Properties.Resources.Delete;
            this.pbxDelete.Location = new System.Drawing.Point(779, 431);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(53, 48);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelete.TabIndex = 45;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Visible = false;
            // 
            // pbxEdit
            // 
            this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEdit.Image = global::FinalAmanda.Properties.Resources.Edit;
            this.pbxEdit.Location = new System.Drawing.Point(838, 431);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(53, 48);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEdit.TabIndex = 44;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Visible = false;
            // 
            // dgvAll
            // 
            this.dgvAll.BackgroundColor = System.Drawing.Color.White;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Location = new System.Drawing.Point(294, 112);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.Size = new System.Drawing.Size(581, 313);
            this.dgvAll.TabIndex = 40;
            this.dgvAll.Visible = false;
            // 
            // pbxClean
            // 
            this.pbxClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClean.Image = global::FinalAmanda.Properties.Resources.Clean;
            this.pbxClean.Location = new System.Drawing.Point(831, 66);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(43, 33);
            this.pbxClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClean.TabIndex = 39;
            this.pbxClean.TabStop = false;
            this.pbxClean.Visible = false;
            this.pbxClean.Click += new System.EventHandler(this.pbxClean_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearch.Image = global::FinalAmanda.Properties.Resources.Search;
            this.pbxSearch.Location = new System.Drawing.Point(789, 66);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(43, 33);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearch.TabIndex = 38;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Visible = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Location = new System.Drawing.Point(293, 70);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 26);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Perquisar";
            this.lblSearch.Visible = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(387, 66);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(396, 33);
            this.tbxSearch.TabIndex = 7;
            this.tbxSearch.Visible = false;
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLog.Location = new System.Drawing.Point(0, 393);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(254, 88);
            this.pnlLog.TabIndex = 2;
            this.pnlLog.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLog_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.pbxBack);
            this.panel2.Location = new System.Drawing.Point(55, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 41);
            this.panel2.TabIndex = 1;
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = global::FinalAmanda.Properties.Resources.Back;
            this.pbxBack.Location = new System.Drawing.Point(3, 5);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(43, 33);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 43;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProduct.Location = new System.Drawing.Point(55, 91);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(254, 88);
            this.pnlProduct.TabIndex = 0;
            this.pnlProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlProduct_MouseClick);
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCategory.Location = new System.Drawing.Point(55, 179);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(254, 88);
            this.pnlCategory.TabIndex = 1;
            this.pnlCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCategory_MouseClick);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUser.Location = new System.Drawing.Point(55, 267);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(254, 88);
            this.pnlUser.TabIndex = 2;
            this.pnlUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUser_MouseClick);
            // 
            // pnlUserProfile
            // 
            this.pnlUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUserProfile.Location = new System.Drawing.Point(55, 355);
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserProfile.Size = new System.Drawing.Size(254, 88);
            this.pnlUserProfile.TabIndex = 2;
            this.pnlUserProfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlUserProfile_MouseClick);
            // 
            // HomeForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 579);
            this.Controls.Add(this.pnlUserProfile);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlUserProfile;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pbxClean;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxBack;
    }
}