namespace Music_Toolbox.Screens
{
    partial class RetrieveTorrent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveTorrent));
            this.btn_load_playlist = new System.Windows.Forms.Button();
            this.dataGrid_tracks = new System.Windows.Forms.DataGridView();
            this.btn_magnet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tracks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load_playlist
            // 
            this.btn_load_playlist.Location = new System.Drawing.Point(12, 12);
            this.btn_load_playlist.Name = "btn_load_playlist";
            this.btn_load_playlist.Size = new System.Drawing.Size(218, 40);
            this.btn_load_playlist.TabIndex = 0;
            this.btn_load_playlist.Text = "Load playlist";
            this.btn_load_playlist.UseVisualStyleBackColor = true;
            this.btn_load_playlist.Click += new System.EventHandler(this.btn_load_playlist_Click);
            // 
            // dataGrid_tracks
            // 
            this.dataGrid_tracks.AllowUserToAddRows = false;
            this.dataGrid_tracks.AllowUserToDeleteRows = false;
            this.dataGrid_tracks.AllowUserToOrderColumns = true;
            this.dataGrid_tracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_tracks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_tracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_tracks.Location = new System.Drawing.Point(236, 12);
            this.dataGrid_tracks.Name = "dataGrid_tracks";
            this.dataGrid_tracks.ReadOnly = true;
            this.dataGrid_tracks.RowTemplate.Height = 28;
            this.dataGrid_tracks.Size = new System.Drawing.Size(785, 590);
            this.dataGrid_tracks.TabIndex = 2;
            // 
            // btn_magnet
            // 
            this.btn_magnet.Location = new System.Drawing.Point(12, 58);
            this.btn_magnet.Name = "btn_magnet";
            this.btn_magnet.Size = new System.Drawing.Size(218, 40);
            this.btn_magnet.TabIndex = 3;
            this.btn_magnet.Text = "Retrieve magnet links";
            this.btn_magnet.UseVisualStyleBackColor = true;
            this.btn_magnet.Click += new System.EventHandler(this.btn_magnet_Click);
            // 
            // RetrieveTorrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 614);
            this.Controls.Add(this.btn_magnet);
            this.Controls.Add(this.dataGrid_tracks);
            this.Controls.Add(this.btn_load_playlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetrieveTorrent";
            this.Text = "Retrieve Torrent Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load_playlist;
        private System.Windows.Forms.DataGridView dataGrid_tracks;
        private System.Windows.Forms.Button btn_magnet;
    }
}