namespace FinalAmanda.Forms
{
    partial class ProductDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm));
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive.Location = new System.Drawing.Point(193, 267);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(65, 22);
            this.cbxActive.TabIndex = 30;
            this.cbxActive.Text = "Ativo";
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(192, 118);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(229, 27);
            this.tbxName.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(189, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 18);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Nome";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(192, 176);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(229, 27);
            this.tbxPrice.TabIndex = 34;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(189, 154);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 18);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Preço";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(192, 234);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 26);
            this.cmbCategory.TabIndex = 41;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(189, 212);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 18);
            this.lblCategory.TabIndex = 40;
            this.lblCategory.Text = "Categoria";
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
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click);
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
            this.pbxSave.Click += new System.EventHandler(this.pbxSave_Click);
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
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 18);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "-";
            this.lblId.Visible = false;
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbxBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
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
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblId;
    }
}