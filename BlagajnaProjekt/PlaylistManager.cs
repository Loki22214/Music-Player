using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlaylistManager : Form
    {
        private Model3 context;
        private Users currentUser;
        private MediaPlayer mediaPlayer;
    
        public PlaylistManager(Users user)
        {
            InitializeComponent();
            context = new Model3();          
            currentUser = user;
            mediaPlayer = new MediaPlayer(currentUser);
            currentUserLabel.Text = user.Username;
            LoadSongs();
            RefreshPlaylistList();
        }
        
        
        private async void PlaylistForm_Load(object sender, EventArgs e)
        {
            await RefreshPlaylistList();
        }
        private async Task RefreshPlaylistList()
        {
            playlistListBox.Items.Clear();
            var playlists = await Task.Run(() => context.Playlists.Where(p => p.UserId == currentUser.Id).ToList());
            foreach (var playlist in playlists)
            {
                playlistListBox.Items.Add(playlist);
            }
        }
        private async void RefreshSongList(Playlists playlist)
        {
            songListBox.Items.Clear();
            var songs = await Task.Run(() => context.PlaylistSongs
                                                    .Where(ps => ps.PlaylistId == playlist.Id)
                                                    .Select(ps => ps.Songs)
                                                    .ToList());
            foreach (var song in songs)
            {
                songListBox.Items.Add(song);
            }
        }

        private void playlistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem != null)
            {
                var selectedPlaylist = (Playlists)playlistListBox.SelectedItem;
                RefreshSongList(selectedPlaylist);
            }
        }
        private void addSongButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem == null || songListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select both a playlist and a song to add.");
                return;
            }

            var selectedPlaylist = (Playlists)playlistListBox.SelectedItem;
            var selectedSong = (Songs)songListBox.SelectedItem;

            // Provjera da li je pjesma vec u playlisti
            if (selectedPlaylist.PlaylistSongs.Any(ps => ps.SongId == selectedSong.Id))
            {
                MessageBox.Show("The song is already in the playlist.");
                return;
            }

            // Unesi pjesmu u playlistu
            var playlistSong = new PlaylistSongs
            {
                PlaylistId = selectedPlaylist.Id,
                SongId = selectedSong.Id
            };

            context.PlaylistSongs.Add(playlistSong);
            context.SaveChanges();
        }

        private void deletePlaylistButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a playlist to delete.");
                return;
            }

            var selectedPlaylist = (Playlists)playlistListBox.SelectedItem;
            context.Playlists.Remove(selectedPlaylist);
            context.SaveChanges();

            RefreshPlaylistList();
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            string playlistName = playlistNameTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(playlistName))
            {
                MessageBox.Show("Please enter a playlist name.");
                return;
            }

            var newPlaylist = new Playlists
            {
                Name = playlistName,
                UserId = currentUser.Id 
            };

            context.Playlists.Add(newPlaylist);
            context.SaveChanges();

            RefreshPlaylistList();
        }
        // Loada sve pjesme u listbox
        private void LoadSongs()
        {
            songListBox.Items.Clear();
            foreach (var song in context.Songs.ToList())
            {
                songListBox.Items.Add(song);
            }
        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (songListBox.SelectedItem != null)
            {
                var selectedSong = (Songs)songListBox.SelectedItem;
                MessageBox.Show($"Selected Song: {selectedSong.Artist} - {selectedSong.Title}");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MediaPlayer mainForm = new MediaPlayer(currentUser);
            mainForm.Show();
            this.Hide();
        }

        private void loadSongFromPlaylistButton_Click(object sender, EventArgs e)
        {
            if (playlistListBox.SelectedItem != null)
            {
                var selectedPlaylist = (Playlists)playlistListBox.SelectedItem;
                RefreshSongList(selectedPlaylist);
            }
            else
            {
                MessageBox.Show("Please select a playlist.");
            }
        }

        private void loadAllSongs_Click(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void playSongButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Show();
            this.Hide(); 
            var selectedSong = (Songs)songListBox.SelectedItem;
            mediaPlayer.playSong(selectedSong);
        }

        private void createSongButton_Click(object sender, EventArgs e)
        {
            string songName = songNameTextBox.Text.Trim();
            string artistName = artistTextBox.Text.Trim();
            string filePath = filePathTextBox.Text.Trim();

            if (string.IsNullOrEmpty(songName) || string.IsNullOrEmpty(artistName) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please fill in all fields and select a file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newSong = new Songs
                {
                    Title = songName,
                    Artist = artistName,
                    FilePath = filePath
                };

                context.Songs.Add(newSong);
                context.SaveChanges();

                MessageBox.Show("Song added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                songNameTextBox.Clear();
                artistTextBox.Clear();
                filePathTextBox.Clear();

                LoadSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding the song: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSongButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.aac|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        /*private void PlaylistForm_Shown(object sender, EventArgs e)
        {
            LoadSongs();
        }*/
    }
}
