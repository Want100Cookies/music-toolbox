namespace Music_Toolbox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_get_torrent_files = new System.Windows.Forms.Button();
            this.btn_retrieve_playlist = new System.Windows.Forms.Button();
            this.btn_rename_files = new System.Windows.Forms.Button();
            this.btn_match_track_file = new System.Windows.Forms.Button();
            this.btn_split_playlist = new System.Windows.Forms.Button();
            this.btn_copy_playlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_get_torrent_files
            // 
            this.btn_get_torrent_files.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get_torrent_files.Location = new System.Drawing.Point(12, 115);
            this.btn_get_torrent_files.Name = "btn_get_torrent_files";
            this.btn_get_torrent_files.Size = new System.Drawing.Size(190, 93);
            this.btn_get_torrent_files.TabIndex = 0;
            this.btn_get_torrent_files.Text = "Get torrent files";
            this.btn_get_torrent_files.UseVisualStyleBackColor = true;
            // 
            // btn_retrieve_playlist
            // 
            this.btn_retrieve_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_retrieve_playlist.Location = new System.Drawing.Point(12, 16);
            this.btn_retrieve_playlist.Name = "btn_retrieve_playlist";
            this.btn_retrieve_playlist.Size = new System.Drawing.Size(190, 93);
            this.btn_retrieve_playlist.TabIndex = 1;
            this.btn_retrieve_playlist.Text = "Retrieve playlist";
            this.btn_retrieve_playlist.UseVisualStyleBackColor = true;
            this.btn_retrieve_playlist.Click += new System.EventHandler(this.btn_retrieve_playlist_Click);
            // 
            // btn_rename_files
            // 
            this.btn_rename_files.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rename_files.Location = new System.Drawing.Point(12, 214);
            this.btn_rename_files.Name = "btn_rename_files";
            this.btn_rename_files.Size = new System.Drawing.Size(190, 93);
            this.btn_rename_files.TabIndex = 2;
            this.btn_rename_files.Text = "Rename files";
            this.btn_rename_files.UseVisualStyleBackColor = true;
            // 
            // btn_match_track_file
            // 
            this.btn_match_track_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_match_track_file.Location = new System.Drawing.Point(12, 313);
            this.btn_match_track_file.Name = "btn_match_track_file";
            this.btn_match_track_file.Size = new System.Drawing.Size(190, 93);
            this.btn_match_track_file.TabIndex = 3;
            this.btn_match_track_file.Text = "Match track to file";
            this.btn_match_track_file.UseVisualStyleBackColor = true;
            // 
            // btn_split_playlist
            // 
            this.btn_split_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_split_playlist.Location = new System.Drawing.Point(12, 412);
            this.btn_split_playlist.Name = "btn_split_playlist";
            this.btn_split_playlist.Size = new System.Drawing.Size(190, 93);
            this.btn_split_playlist.TabIndex = 4;
            this.btn_split_playlist.Text = "Split playlist";
            this.btn_split_playlist.UseVisualStyleBackColor = true;
            // 
            // btn_copy_playlist
            // 
            this.btn_copy_playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy_playlist.Location = new System.Drawing.Point(12, 511);
            this.btn_copy_playlist.Name = "btn_copy_playlist";
            this.btn_copy_playlist.Size = new System.Drawing.Size(190, 93);
            this.btn_copy_playlist.TabIndex = 5;
            this.btn_copy_playlist.Text = "Copy playlist";
            this.btn_copy_playlist.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 615);
            this.Controls.Add(this.btn_copy_playlist);
            this.Controls.Add(this.btn_split_playlist);
            this.Controls.Add(this.btn_match_track_file);
            this.Controls.Add(this.btn_rename_files);
            this.Controls.Add(this.btn_retrieve_playlist);
            this.Controls.Add(this.btn_get_torrent_files);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 671);
            this.MinimumSize = new System.Drawing.Size(240, 671);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Music Toolbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_get_torrent_files;
        private System.Windows.Forms.Button btn_retrieve_playlist;
        private System.Windows.Forms.Button btn_rename_files;
        private System.Windows.Forms.Button btn_match_track_file;
        private System.Windows.Forms.Button btn_split_playlist;
        private System.Windows.Forms.Button btn_copy_playlist;
    }
}

