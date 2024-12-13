
namespace MusicPlayer
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
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createSongButton = new System.Windows.Forms.Button();
            this.loadSongButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.addSongButton.Location = new System.Drawing.Point(264, 67);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(75, 23);
            this.addSongButton.TabIndex = 3;
            this.addSongButton.Text = "Add";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.Location = new System.Drawing.Point(264, 125);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.deletePlaylistButton.TabIndex = 4;
            this.deletePlaylistButton.Text = "Delete";
            this.deletePlaylistButton.UseVisualStyleBackColor = true;
            this.deletePlaylistButton.Click += new System.EventHandler(this.deletePlaylistButton_Click);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Location = new System.Drawing.Point(370, 181);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.createPlaylistButton.TabIndex = 5;
            this.createPlaylistButton.Text = "Create";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // playlistNameTextbox
            // 
            this.playlistNameTextbox.Location = new System.Drawing.Point(264, 183);
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
            this.returnButton.Location = new System.Drawing.Point(264, 209);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "<--";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loadSongFromPlaylistButton
            // 
            this.loadSongFromPlaylistButton.Location = new System.Drawing.Point(264, 96);
            this.loadSongFromPlaylistButton.Name = "loadSongFromPlaylistButton";
            this.loadSongFromPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.loadSongFromPlaylistButton.TabIndex = 9;
            this.loadSongFromPlaylistButton.Text = "Open";
            this.loadSongFromPlaylistButton.UseVisualStyleBackColor = true;
            this.loadSongFromPlaylistButton.Click += new System.EventHandler(this.loadSongFromPlaylistButton_Click);
            // 
            // loadAllSongs
            // 
            this.loadAllSongs.Location = new System.Drawing.Point(264, 154);
            this.loadAllSongs.Name = "loadAllSongs";
            this.loadAllSongs.Size = new System.Drawing.Size(75, 23);
            this.loadAllSongs.TabIndex = 10;
            this.loadAllSongs.Text = "Media";
            this.loadAllSongs.UseVisualStyleBackColor = true;
            this.loadAllSongs.Click += new System.EventHandler(this.loadAllSongs_Click);
            // 
            // playSongButton
            // 
            this.playSongButton.Location = new System.Drawing.Point(264, 38);
            this.playSongButton.Name = "playSongButton";
            this.playSongButton.Size = new System.Drawing.Size(75, 23);
            this.playSongButton.TabIndex = 11;
            this.playSongButton.Text = "Play";
            this.playSongButton.UseVisualStyleBackColor = true;
            this.playSongButton.Click += new System.EventHandler(this.playSongButton_Click);
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(264, 324);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(100, 20);
            this.artistTextBox.TabIndex = 12;
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.Location = new System.Drawing.Point(370, 324);
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.songNameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Song";
            // 
            // createSongButton
            // 
            this.createSongButton.Location = new System.Drawing.Point(264, 351);
            this.createSongButton.Name = "createSongButton";
            this.createSongButton.Size = new System.Drawing.Size(75, 23);
            this.createSongButton.TabIndex = 19;
            this.createSongButton.Text = "Create";
            this.createSongButton.UseVisualStyleBackColor = true;
            this.createSongButton.Click += new System.EventHandler(this.createSongButton_Click);
            // 
            // loadSongButton
            // 
            this.loadSongButton.Location = new System.Drawing.Point(582, 322);
            this.loadSongButton.Name = "loadSongButton";
            this.loadSongButton.Size = new System.Drawing.Size(75, 23);
            this.loadSongButton.TabIndex = 20;
            this.loadSongButton.Text = "Load";
            this.loadSongButton.UseVisualStyleBackColor = true;
            this.loadSongButton.Click += new System.EventHandler(this.loadSongButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(476, 324);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(100, 20);
            this.filePathTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Filepath";
            // 
            // PlaylistManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.loadSongButton);
            this.Controls.Add(this.createSongButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.songNameTextBox);
            this.Controls.Add(this.artistTextBox);
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
            this.Name = "PlaylistManager";
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
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox songNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createSongButton;
        private System.Windows.Forms.Button loadSongButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label5;
    }
}