namespace FinalAmanda.Forms
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.pbxClean = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeColumns = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLog.Location = new System.Drawing.Point(7, 58);
            this.dgvLog.MultiSelect = false;
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(581, 313);
            this.dgvLog.TabIndex = 45;
            // 
            // pbxClean
            // 
            this.pbxClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxClean.Image = global::FinalAmanda.Properties.Resources.Clean;
            this.pbxClean.Location = new System.Drawing.Point(491, 18);
            this.pbxClean.Name = "pbxClean";
            this.pbxClean.Size = new System.Drawing.Size(33, 30);
            this.pbxClean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClean.TabIndex = 44;
            this.pbxClean.TabStop = false;
            this.pbxClean.Click += new System.EventHandler(this.pbxClean_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSearch.Image = global::FinalAmanda.Properties.Resources.Search;
            this.pbxSearch.Location = new System.Drawing.Point(452, 18);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(33, 30);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSearch.TabIndex = 43;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxBack.Image = global::FinalAmanda.Properties.Resources.Back;
            this.pbxBack.Location = new System.Drawing.Point(2, 377);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(53, 48);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBack.TabIndex = 42;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(103, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(342, 27);
            this.tbxSearch.TabIndex = 41;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(87, 18);
            this.lblSearch.TabIndex = 40;
            this.lblSearch.Text = "Pesquisar";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 429);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.pbxClean);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.PictureBox pbxClean;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}