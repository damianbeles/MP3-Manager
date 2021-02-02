namespace MP3Manager
{
    partial class MP3Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MP3Manager));
            this.playlistsGroupBox = new System.Windows.Forms.GroupBox();
            this.playlistsNewButton = new System.Windows.Forms.Button();
            this.playlistsNewTextBox = new System.Windows.Forms.TextBox();
            this.playlistsSearchTextBox = new System.Windows.Forms.TextBox();
            this.playlistsListBox = new System.Windows.Forms.ListBox();
            this.songsGroupBox = new System.Windows.Forms.GroupBox();
            this.songsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.songsAddToPlaylistButton = new System.Windows.Forms.Button();
            this.songsSearchTextBox = new System.Windows.Forms.TextBox();
            this.selectedPlaylistGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedPlaylistMoveSongDownButton = new System.Windows.Forms.Button();
            this.selectedPlaylistDeleteSongButton = new System.Windows.Forms.Button();
            this.selectedPlaylistMoveSongUpButton = new System.Windows.Forms.Button();
            this.selectedPlaylistSearchTextBox = new System.Windows.Forms.TextBox();
            this.selectedPlaylistSongsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.selectedPlaylistSearchPictureBox = new System.Windows.Forms.PictureBox();
            this.songsSearchPictureBox = new System.Windows.Forms.PictureBox();
            this.playlistsSearchPictureBox = new System.Windows.Forms.PictureBox();
            this.playlistsGroupBox.SuspendLayout();
            this.songsGroupBox.SuspendLayout();
            this.selectedPlaylistGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPlaylistSearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsSearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsSearchPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistsGroupBox
            // 
            this.playlistsGroupBox.Controls.Add(this.playlistsNewButton);
            this.playlistsGroupBox.Controls.Add(this.playlistsNewTextBox);
            this.playlistsGroupBox.Controls.Add(this.playlistsSearchPictureBox);
            this.playlistsGroupBox.Controls.Add(this.playlistsSearchTextBox);
            this.playlistsGroupBox.Controls.Add(this.playlistsListBox);
            this.playlistsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.playlistsGroupBox.Name = "playlistsGroupBox";
            this.playlistsGroupBox.Size = new System.Drawing.Size(367, 546);
            this.playlistsGroupBox.TabIndex = 0;
            this.playlistsGroupBox.TabStop = false;
            this.playlistsGroupBox.Text = "Playlists";
            // 
            // playlistsNewButton
            // 
            this.playlistsNewButton.Enabled = false;
            this.playlistsNewButton.Location = new System.Drawing.Point(325, 505);
            this.playlistsNewButton.Name = "playlistsNewButton";
            this.playlistsNewButton.Size = new System.Drawing.Size(36, 35);
            this.playlistsNewButton.TabIndex = 4;
            this.playlistsNewButton.Text = "+";
            this.playlistsNewButton.UseVisualStyleBackColor = true;
            this.playlistsNewButton.Click += new System.EventHandler(this.playlistsNewButton_Click);
            // 
            // playlistsNewTextBox
            // 
            this.playlistsNewTextBox.Location = new System.Drawing.Point(6, 505);
            this.playlistsNewTextBox.Name = "playlistsNewTextBox";
            this.playlistsNewTextBox.Size = new System.Drawing.Size(313, 35);
            this.playlistsNewTextBox.TabIndex = 3;
            this.playlistsNewTextBox.TextChanged += new System.EventHandler(this.playlistsNewTextBox_TextChanged);
            // 
            // playlistsSearchTextBox
            // 
            this.playlistsSearchTextBox.Location = new System.Drawing.Point(6, 34);
            this.playlistsSearchTextBox.Name = "playlistsSearchTextBox";
            this.playlistsSearchTextBox.Size = new System.Drawing.Size(313, 35);
            this.playlistsSearchTextBox.TabIndex = 2;
            // 
            // playlistsListBox
            // 
            this.playlistsListBox.FormattingEnabled = true;
            this.playlistsListBox.ItemHeight = 29;
            this.playlistsListBox.Location = new System.Drawing.Point(6, 75);
            this.playlistsListBox.Name = "playlistsListBox";
            this.playlistsListBox.Size = new System.Drawing.Size(355, 410);
            this.playlistsListBox.TabIndex = 1;
            this.playlistsListBox.SelectedIndexChanged += new System.EventHandler(this.playlistsListBox_SelectedIndexChanged);
            // 
            // songsGroupBox
            // 
            this.songsGroupBox.Controls.Add(this.songsCheckedListBox);
            this.songsGroupBox.Controls.Add(this.songsAddToPlaylistButton);
            this.songsGroupBox.Controls.Add(this.songsSearchPictureBox);
            this.songsGroupBox.Controls.Add(this.songsSearchTextBox);
            this.songsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songsGroupBox.Location = new System.Drawing.Point(385, 12);
            this.songsGroupBox.Name = "songsGroupBox";
            this.songsGroupBox.Size = new System.Drawing.Size(367, 546);
            this.songsGroupBox.TabIndex = 5;
            this.songsGroupBox.TabStop = false;
            this.songsGroupBox.Text = "Songs";
            // 
            // songsCheckedListBox
            // 
            this.songsCheckedListBox.FormattingEnabled = true;
            this.songsCheckedListBox.Location = new System.Drawing.Point(6, 75);
            this.songsCheckedListBox.Name = "songsCheckedListBox";
            this.songsCheckedListBox.Size = new System.Drawing.Size(355, 424);
            this.songsCheckedListBox.TabIndex = 6;
            this.songsCheckedListBox.DoubleClick += new System.EventHandler(this.songsCheckedListBox_DoubleClick);
            // 
            // songsAddToPlaylistButton
            // 
            this.songsAddToPlaylistButton.Location = new System.Drawing.Point(325, 505);
            this.songsAddToPlaylistButton.Name = "songsAddToPlaylistButton";
            this.songsAddToPlaylistButton.Size = new System.Drawing.Size(36, 35);
            this.songsAddToPlaylistButton.TabIndex = 5;
            this.songsAddToPlaylistButton.Text = ">";
            this.songsAddToPlaylistButton.UseVisualStyleBackColor = true;
            this.songsAddToPlaylistButton.Click += new System.EventHandler(this.songsAddToPlaylistButton_Click);
            // 
            // songsSearchTextBox
            // 
            this.songsSearchTextBox.Location = new System.Drawing.Point(6, 34);
            this.songsSearchTextBox.Name = "songsSearchTextBox";
            this.songsSearchTextBox.Size = new System.Drawing.Size(313, 35);
            this.songsSearchTextBox.TabIndex = 2;
            // 
            // selectedPlaylistGroupBox
            // 
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistSongsCheckedListBox);
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistMoveSongDownButton);
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistDeleteSongButton);
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistMoveSongUpButton);
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistSearchPictureBox);
            this.selectedPlaylistGroupBox.Controls.Add(this.selectedPlaylistSearchTextBox);
            this.selectedPlaylistGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPlaylistGroupBox.Location = new System.Drawing.Point(758, 12);
            this.selectedPlaylistGroupBox.Name = "selectedPlaylistGroupBox";
            this.selectedPlaylistGroupBox.Size = new System.Drawing.Size(367, 546);
            this.selectedPlaylistGroupBox.TabIndex = 6;
            this.selectedPlaylistGroupBox.TabStop = false;
            this.selectedPlaylistGroupBox.Text = "Selected Playlist";
            // 
            // selectedPlaylistMoveSongDownButton
            // 
            this.selectedPlaylistMoveSongDownButton.Location = new System.Drawing.Point(6, 505);
            this.selectedPlaylistMoveSongDownButton.Name = "selectedPlaylistMoveSongDownButton";
            this.selectedPlaylistMoveSongDownButton.Size = new System.Drawing.Size(36, 35);
            this.selectedPlaylistMoveSongDownButton.TabIndex = 7;
            this.selectedPlaylistMoveSongDownButton.Text = "v";
            this.selectedPlaylistMoveSongDownButton.UseVisualStyleBackColor = true;
            this.selectedPlaylistMoveSongDownButton.Click += new System.EventHandler(this.selectedPlaylistMoveSongDownButton_Click);
            // 
            // selectedPlaylistDeleteSongButton
            // 
            this.selectedPlaylistDeleteSongButton.Location = new System.Drawing.Point(172, 505);
            this.selectedPlaylistDeleteSongButton.Name = "selectedPlaylistDeleteSongButton";
            this.selectedPlaylistDeleteSongButton.Size = new System.Drawing.Size(36, 35);
            this.selectedPlaylistDeleteSongButton.TabIndex = 6;
            this.selectedPlaylistDeleteSongButton.Text = "-";
            this.selectedPlaylistDeleteSongButton.UseVisualStyleBackColor = true;
            this.selectedPlaylistDeleteSongButton.Click += new System.EventHandler(this.selectedPlaylistDeleteSongButton_Click);
            // 
            // selectedPlaylistMoveSongUpButton
            // 
            this.selectedPlaylistMoveSongUpButton.Location = new System.Drawing.Point(325, 505);
            this.selectedPlaylistMoveSongUpButton.Name = "selectedPlaylistMoveSongUpButton";
            this.selectedPlaylistMoveSongUpButton.Size = new System.Drawing.Size(36, 35);
            this.selectedPlaylistMoveSongUpButton.TabIndex = 5;
            this.selectedPlaylistMoveSongUpButton.Text = "^";
            this.selectedPlaylistMoveSongUpButton.UseVisualStyleBackColor = true;
            this.selectedPlaylistMoveSongUpButton.Click += new System.EventHandler(this.selectedPlaylistMoveSongUpButton_Click);
            // 
            // selectedPlaylistSearchTextBox
            // 
            this.selectedPlaylistSearchTextBox.Location = new System.Drawing.Point(6, 34);
            this.selectedPlaylistSearchTextBox.Name = "selectedPlaylistSearchTextBox";
            this.selectedPlaylistSearchTextBox.Size = new System.Drawing.Size(313, 35);
            this.selectedPlaylistSearchTextBox.TabIndex = 2;
            // 
            // selectedPlaylistSongsCheckedListBox
            // 
            this.selectedPlaylistSongsCheckedListBox.FormattingEnabled = true;
            this.selectedPlaylistSongsCheckedListBox.Location = new System.Drawing.Point(6, 75);
            this.selectedPlaylistSongsCheckedListBox.Name = "selectedPlaylistSongsCheckedListBox";
            this.selectedPlaylistSongsCheckedListBox.Size = new System.Drawing.Size(355, 424);
            this.selectedPlaylistSongsCheckedListBox.TabIndex = 8;
            this.selectedPlaylistSongsCheckedListBox.DoubleClick += new System.EventHandler(this.selectedPlaylistSongsCheckedListBox_DoubleClick);
            // 
            // selectedPlaylistSearchPictureBox
            // 
            this.selectedPlaylistSearchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectedPlaylistSearchPictureBox.Image = global::MP3Manager.Properties.Resources.search_icon;
            this.selectedPlaylistSearchPictureBox.Location = new System.Drawing.Point(325, 34);
            this.selectedPlaylistSearchPictureBox.Name = "selectedPlaylistSearchPictureBox";
            this.selectedPlaylistSearchPictureBox.Size = new System.Drawing.Size(36, 35);
            this.selectedPlaylistSearchPictureBox.TabIndex = 1;
            this.selectedPlaylistSearchPictureBox.TabStop = false;
            this.selectedPlaylistSearchPictureBox.Click += new System.EventHandler(this.selectedPlaylistSearchPictureBox_Click);
            // 
            // songsSearchPictureBox
            // 
            this.songsSearchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songsSearchPictureBox.Image = global::MP3Manager.Properties.Resources.search_icon;
            this.songsSearchPictureBox.Location = new System.Drawing.Point(325, 34);
            this.songsSearchPictureBox.Name = "songsSearchPictureBox";
            this.songsSearchPictureBox.Size = new System.Drawing.Size(36, 35);
            this.songsSearchPictureBox.TabIndex = 1;
            this.songsSearchPictureBox.TabStop = false;
            this.songsSearchPictureBox.Click += new System.EventHandler(this.songsSearchPictureBox_Click);
            // 
            // playlistsSearchPictureBox
            // 
            this.playlistsSearchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playlistsSearchPictureBox.Image = global::MP3Manager.Properties.Resources.search_icon;
            this.playlistsSearchPictureBox.Location = new System.Drawing.Point(325, 34);
            this.playlistsSearchPictureBox.Name = "playlistsSearchPictureBox";
            this.playlistsSearchPictureBox.Size = new System.Drawing.Size(36, 35);
            this.playlistsSearchPictureBox.TabIndex = 1;
            this.playlistsSearchPictureBox.TabStop = false;
            this.playlistsSearchPictureBox.Click += new System.EventHandler(this.playlistsSearchPictureBox_Click);
            // 
            // MP3Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 569);
            this.Controls.Add(this.selectedPlaylistGroupBox);
            this.Controls.Add(this.songsGroupBox);
            this.Controls.Add(this.playlistsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MP3Manager";
            this.Text = "MP3Manager | By Damian-Teodor | LISP Backend implementation";
            this.Load += new System.EventHandler(this.MP3Manager_Load);
            this.playlistsGroupBox.ResumeLayout(false);
            this.playlistsGroupBox.PerformLayout();
            this.songsGroupBox.ResumeLayout(false);
            this.songsGroupBox.PerformLayout();
            this.selectedPlaylistGroupBox.ResumeLayout(false);
            this.selectedPlaylistGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPlaylistSearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsSearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsSearchPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox playlistsGroupBox;
        private System.Windows.Forms.Button playlistsNewButton;
        private System.Windows.Forms.TextBox playlistsNewTextBox;
        private System.Windows.Forms.PictureBox playlistsSearchPictureBox;
        private System.Windows.Forms.TextBox playlistsSearchTextBox;
        private System.Windows.Forms.ListBox playlistsListBox;
        private System.Windows.Forms.GroupBox songsGroupBox;
        private System.Windows.Forms.Button songsAddToPlaylistButton;
        private System.Windows.Forms.PictureBox songsSearchPictureBox;
        private System.Windows.Forms.TextBox songsSearchTextBox;
        private System.Windows.Forms.GroupBox selectedPlaylistGroupBox;
        private System.Windows.Forms.Button selectedPlaylistMoveSongUpButton;
        private System.Windows.Forms.PictureBox selectedPlaylistSearchPictureBox;
        private System.Windows.Forms.TextBox selectedPlaylistSearchTextBox;
        private System.Windows.Forms.Button selectedPlaylistMoveSongDownButton;
        private System.Windows.Forms.Button selectedPlaylistDeleteSongButton;
        private System.Windows.Forms.CheckedListBox songsCheckedListBox;
        private System.Windows.Forms.CheckedListBox selectedPlaylistSongsCheckedListBox;
    }
}

