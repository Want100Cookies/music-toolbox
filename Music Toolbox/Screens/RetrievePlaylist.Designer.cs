namespace Music_Toolbox.Screens
{
    partial class RetrievePlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrievePlaylist));
            this.grpBox_login = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_months = new System.Windows.Forms.Label();
            this.num_months = new System.Windows.Forms.NumericUpDown();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.dataGrid_recent = new System.Windows.Forms.DataGridView();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.btn_retrieve = new System.Windows.Forms.Button();
            this.grpBox_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_months)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_recent)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_login
            // 
            this.grpBox_login.Controls.Add(this.btn_save);
            this.grpBox_login.Controls.Add(this.lbl_months);
            this.grpBox_login.Controls.Add(this.num_months);
            this.grpBox_login.Controls.Add(this.btn_retrieve);
            this.grpBox_login.Controls.Add(this.txt_username);
            this.grpBox_login.Controls.Add(this.lbl_username);
            this.grpBox_login.Location = new System.Drawing.Point(12, 12);
            this.grpBox_login.Name = "grpBox_login";
            this.grpBox_login.Size = new System.Drawing.Size(228, 195);
            this.grpBox_login.TabIndex = 0;
            this.grpBox_login.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(15, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(198, 33);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save (to xml)";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_months
            // 
            this.lbl_months.AutoSize = true;
            this.lbl_months.Location = new System.Drawing.Point(27, 68);
            this.lbl_months.Name = "lbl_months";
            this.lbl_months.Size = new System.Drawing.Size(66, 20);
            this.lbl_months.TabIndex = 3;
            this.lbl_months.Text = "Months:";
            // 
            // num_months
            // 
            this.num_months.Location = new System.Drawing.Point(99, 66);
            this.num_months.Name = "num_months";
            this.num_months.Size = new System.Drawing.Size(114, 26);
            this.num_months.TabIndex = 2;
            this.num_months.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(99, 34);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(114, 26);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Want100Cookies";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(11, 37);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(87, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // dataGrid_recent
            // 
            this.dataGrid_recent.AllowUserToAddRows = false;
            this.dataGrid_recent.AllowUserToDeleteRows = false;
            this.dataGrid_recent.AllowUserToOrderColumns = true;
            this.dataGrid_recent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_recent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_recent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_recent.Location = new System.Drawing.Point(246, 21);
            this.dataGrid_recent.Name = "dataGrid_recent";
            this.dataGrid_recent.ReadOnly = true;
            this.dataGrid_recent.RowTemplate.Height = 28;
            this.dataGrid_recent.Size = new System.Drawing.Size(938, 977);
            this.dataGrid_recent.TabIndex = 1;
            // 
            // progressbar
            // 
            this.progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressbar.Location = new System.Drawing.Point(12, 1004);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(1172, 30);
            this.progressbar.TabIndex = 2;
            // 
            // btn_retrieve
            // 
            this.btn_retrieve.Location = new System.Drawing.Point(15, 107);
            this.btn_retrieve.Name = "btn_retrieve";
            this.btn_retrieve.Size = new System.Drawing.Size(198, 33);
            this.btn_retrieve.TabIndex = 1;
            this.btn_retrieve.Text = "Retrieve";
            this.btn_retrieve.UseVisualStyleBackColor = true;
            this.btn_retrieve.Click += new System.EventHandler(this.btn_retrieve_Click);
            // 
            // RetrievePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 1046);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.dataGrid_recent);
            this.Controls.Add(this.grpBox_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetrievePlaylist";
            this.Text = "Retrieve Playlist";
            this.grpBox_login.ResumeLayout(false);
            this.grpBox_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_months)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_recent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_login;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.DataGridView dataGrid_recent;
        private System.Windows.Forms.Label lbl_months;
        private System.Windows.Forms.NumericUpDown num_months;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_retrieve;
    }
}