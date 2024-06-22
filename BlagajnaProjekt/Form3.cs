using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlagajnaProjekt
{
    public partial class Form3 : Form
    {
        private Model3 context;
        private Users currentUser;
        public Form3(Users user)
        {
            InitializeComponent();
            context = new Model3();
            currentUser = user;
            currentUserLabel.Text = user.Username;
            LoadSongs();
            RefreshPlaylistList();
        }
        
        
        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            RefreshPlaylistList();
        }
        private void RefreshPlaylistList()
        {
            playlistListBox.Items.Clear();
            var playlists = context.Playlists.Where(p => p.UserId == currentUser.Id).ToList();
            foreach (var playlist in context.Playlists.ToList())
            {
                playlistListBox.Items.Add(playlist);
            }
        }
        private void RefreshSongList(Playlists playlist)
        {
            songListBox.Items.Clear();
            var songs = context.PlaylistSongs
                               .Where(ps => ps.PlaylistId == playlist.Id)
                               .Select(ps => ps.Songs)
                               .ToList();
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

            // Check if the song is already in the playlist
            if (selectedPlaylist.PlaylistSongs.Any(ps => ps.SongId == selectedSong.Id))
            {
                MessageBox.Show("The song is already in the playlist.");
                return;
            }

            // Add song to playlist
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
                UserId = currentUser.Id // Ensure the UserId is correctly assigned
            };

            context.Playlists.Add(newPlaylist);
            context.SaveChanges();

            RefreshPlaylistList();
        }
        // Load songs into the songListBox
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
                MessageBox.Show($"Selected Song: {selectedSong.Title}");
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            MediaPlayer mainForm = new MediaPlayer(currentUser);
            mainForm.Show();
            this.Hide(); // Optionally hide the login form
        }

        /*private void PlaylistForm_Shown(object sender, EventArgs e)
        {
            LoadSongs();
        }*/
    }
}
