namespace FinalAmanda.Forms
{
    partial class ProductAllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAllForm));
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlLogFor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.pnlLogFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = global::FinalAmanda.Properties.Resources.Add;
            this.pbxAdd.Location = new System.Drawing.Point(476, 380);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(53, 48);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 51;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDelete.Image = global::FinalAmanda.Properties.Resources.Delete;
            this.pbxDelete.Location = new System.Drawing.Point(535, 380);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(53, 48);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDelete.TabIndex = 50;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
            // 
            // pbxEdit
            // 
            this.pbxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxEdit.Image = global::FinalAmanda.Properties.Resources.Edit;
            this.pbxEdit.Location = new System.Drawing.Point(594, 380);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(53, 48);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEdit.TabIndex = 49;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduct.Location = new System.Drawing.Point(66, 61);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(581, 313);
            this.dgvProduct.TabIndex = 48;
            // 
            // pbxClean
            // 
            this.pbxClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClean.Image = global::FinalAmanda.Properties.Resources.Clean;
            this.pbxClean.Location = new System.Drawing.Point(550, 21);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(33, 30);
            this.pbxClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClean.TabIndex = 47;
            this.pbxClean.TabStop = false;
            this.pbxClean.Click += new System.EventHandler(this.pbxClean_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearch.Image = global::FinalAmanda.Properties.Resources.Search;
            this.pbxSearch.Location = new System.Drawing.Point(511, 21);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(33, 30);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearch.TabIndex = 46;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = global::FinalAmanda.Properties.Resources.Back;
            this.pbxBack.Location = new System.Drawing.Point(61, 380);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(53, 48);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 45;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(162, 22);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(342, 27);
            this.tbxSearch.TabIndex = 44;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(71, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 18);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Pesquisar";
            // 
            // pnlLogFor
            // 
            this.pnlLogFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLogFor.Controls.Add(this.pbxAdd);
            this.pnlLogFor.Controls.Add(this.dgvProduct);
            this.pnlLogFor.Controls.Add(this.pbxDelete);
            this.pnlLogFor.Controls.Add(this.lblSearch);
            this.pnlLogFor.Controls.Add(this.pbxEdit);
            this.pnlLogFor.Controls.Add(this.tbxSearch);
            this.pnlLogFor.Controls.Add(this.pbxBack);
            this.pnlLogFor.Controls.Add(this.pbxClean);
            this.pnlLogFor.Controls.Add(this.pbxSearch);
            this.pnlLogFor.Location = new System.Drawing.Point(27, 24);
            this.pnlLogFor.Name = "pnlLogFor";
            this.pnlLogFor.Size = new System.Drawing.Size(704, 432);
            this.pnlLogFor.TabIndex = 52;
            // 
            // ProductAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.pnlLogFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.pnlLogFor.ResumeLayout(false);
            this.pnlLogFor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxDelete;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.PictureBox pbxClean;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlLogFor;
    }
}