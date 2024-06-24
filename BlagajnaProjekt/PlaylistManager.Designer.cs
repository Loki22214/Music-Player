
namespace BlagajnaProjekt
{
    partial class PlaylistManager
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
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.songListBox = new System.Windows.Forms.ListBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.playlistNameTextbox = new System.Windows.Forms.TextBox();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.loadSongFromPlaylistButton = new System.Windows.Forms.Button();
            this.loadAllSongs = new System.Windows.Forms.Button();
            this.playSongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(12, 12);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(120, 433);
            this.playlistListBox.TabIndex = 0;
            // 
            // songListBox
            // 
            this.songListBox.FormattingEnabled = true;
            this.songListBox.Location = new System.Drawing.Point(138, 12);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(120, 433);
            this.songListBox.TabIndex = 1;
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(264, 41);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 23);
            this.addSongButton.TabIndex = 3;
            this.addSongButton.Text = "Add";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.Location = new System.Drawing.Point(264, 99);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlaylistButton.TabIndex = 4;
            this.deletePlaylistButton.Text = "Delete";
            this.deletePlaylistButton.UseVisualStyleBackColor = true;
            this.deletePlaylistButton.Click += new System.EventHandler(this.deletePlaylistButton_Click);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Location = new System.Drawing.Point(370, 155);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.createPlaylistButton.TabIndex = 5;
            this.createPlaylistButton.Text = "Create";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // playlistNameTextbox
            // 
            this.playlistNameTextbox.Location = new System.Drawing.Point(264, 157);
            this.playlistNameTextbox.Name = "playlistNameTextbox";
            this.playlistNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.playlistNameTextbox.TabIndex = 6;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(716, 15);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(35, 13);
            this.currentUserLabel.TabIndex = 7;
            this.currentUserLabel.Text = "label1";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(264, 183);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "<--";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loadSongFromPlaylistButton
            // 
            this.loadSongFromPlaylistButton.Location = new System.Drawing.Point(264, 70);
            this.loadSongFromPlaylistButton.Name = "loadSongFromPlaylistButton";
            this.loadSongFromPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.loadSongFromPlaylistButton.TabIndex = 9;
            this.loadSongFromPlaylistButton.Text = "Open";
            this.loadSongFromPlaylistButton.UseVisualStyleBackColor = true;
            this.loadSongFromPlaylistButton.Click += new System.EventHandler(this.loadSongFromPlaylistButton_Click);
            // 
            // loadAllSongs
            // 
            this.loadAllSongs.Location = new System.Drawing.Point(264, 128);
            this.loadAllSongs.Name = "loadAllSongs";
            this.loadAllSongs.Size = new System.Drawing.Size(75, 23);
            this.loadAllSongs.TabIndex = 10;
            this.loadAllSongs.Text = "Media";
            this.loadAllSongs.UseVisualStyleBackColor = true;
            this.loadAllSongs.Click += new System.EventHandler(this.loadAllSongs_Click);
            // 
            // playSongButton
            // 
            this.playSongButton.Location = new System.Drawing.Point(264, 12);
            this.playSongButton.Name = "playSongButton";
            this.playSongButton.Size = new System.Drawing.Size(75, 23);
            this.playSongButton.TabIndex = 11;
            this.playSongButton.Text = "Play";
            this.playSongButton.UseVisualStyleBackColor = true;
            this.playSongButton.Click += new System.EventHandler(this.playSongButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playSongButton);
            this.Controls.Add(this.loadAllSongs);
            this.Controls.Add(this.loadSongFromPlaylistButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.playlistNameTextbox);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.songListBox);
            this.Controls.Add(this.playlistListBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.TextBox playlistNameTextbox;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button loadSongFromPlaylistButton;
        private System.Windows.Forms.Button loadAllSongs;
        private System.Windows.Forms.Button playSongButton;
    }
}