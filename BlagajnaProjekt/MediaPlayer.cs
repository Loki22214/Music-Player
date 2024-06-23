using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace BlagajnaProjekt
{
    public partial class MediaPlayer : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private Timer timer;
        private Model3 context;
        private Songs song;
        private int currentSongIndex;
        private int totalSongs;
        private Users currentUser;

        public MediaPlayer(Users user )
        {
            InitializeComponent();
            waveOut = new WaveOutEvent();
            currentUser = user;
            userLabel.Text = user.Username;

            // Initialize context and get total number of songs
            context = new Model3();
            totalSongs = context.Songs.Count();
            currentSongIndex = 2; // Start with the first song

            LoadAndPlaySong();

            // Set up the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick;
        }

        public void LoadAndPlaySong()
        {
            var song = context.Songs.OrderBy(s => s.Id).Skip(currentSongIndex).FirstOrDefault();

            if (song != null)
            {
                if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
                {
                    waveOut.Stop();
                }

                if (audioFileReader != null)
                {
                    audioFileReader.Dispose();
                }

                // Store the file path in a variable
                string filePath = song.FilePath;

                // Use the file path variable with the AudioFileReader
                audioFileReader = new AudioFileReader(@filePath);

                // Initialize waveOut with the audioFileReader
                waveOut.Init(audioFileReader);

                // Set the initial volume
                waveOut.Volume = volumeTrackBar.Value / 100f;

                // Set the volume label text
                volumeLabel.Text = $"Volume: {volumeTrackBar.Value}%";

                // Set up the progress track bar
                progressTrackBar.Minimum = 0;
                progressTrackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                // Set the total time label
                totalTimeLabel.Text = TimeSpan.FromSeconds(progressTrackBar.Maximum).ToString(@"mm\:ss");

                // Display the artist information
                displayArtist.Text = $"{song.Artist} - {song.Title}";
            }
            else
            {
                MessageBox.Show("No song found in the database.");
            }
        }



        private void playButton_Click(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                waveOut.Play();
                timer.Start();
            }
            else
            {
                MessageBox.Show("No song loaded.");
            }
        }
          
        private void pauseButton_Click(object sender, EventArgs e)
        {
            waveOut.Pause();
            timer.Stop();
        }
      

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            waveOut.Dispose();
            audioFileReader.Dispose();
            timer.Dispose();
            base.OnFormClosing(e);
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            waveOut.Volume = volumeTrackBar.Value / 100f;
            volumeLabel.Text = $"Volume: {volumeTrackBar.Value}%";
        }

        private void progressTrackBar_Scroll(object sender, EventArgs e)
        {
            audioFileReader.CurrentTime = TimeSpan.FromSeconds(progressTrackBar.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressTrackBar.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
            currentTimeLabel.Text = audioFileReader.CurrentTime.ToString(@"mm\:ss");
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
                LoadAndPlaySong();
                playButton_Click(sender, e); // Start playing the previous song
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < totalSongs - 1)
            {
                currentSongIndex++;
                LoadAndPlaySong();
                playButton_Click(sender, e); // Start playing the next song
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
            this.Close(); 
        }

        private void playlistFormButton_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3(currentUser);
            mainForm.Show();
            this.Hide(); 
        }
    }
}
