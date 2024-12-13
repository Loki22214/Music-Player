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

namespace MusicPlayer
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

            // inicijalizacija konteksta 
            context = new Model3();
            totalSongs = context.Songs.Count();
            currentSongIndex = 2; 

            LoadAndPlaySong();

            // konfiguracija timera
            timer = new Timer();
            timer.Interval = 1000; // 1 sekunda
            timer.Tick += timer1_Tick;
        }

        public void playSong(Songs song)
        {
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

                // konfiguracija filepatha
                string filePath = song.FilePath;

                
                audioFileReader = new AudioFileReader(@filePath);

               
                waveOut.Init(audioFileReader);

                // konfiguracija pojacavanje i smanjivanje zvuka
                waveOut.Volume = volumeTrackBar.Value / 100f;

                
                volumeLabel.Text = $"Volume: {volumeTrackBar.Value}%";

                // konfiguracija trake za premotavanje glazbe
                progressTrackBar.Minimum = 0;
                progressTrackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                
                totalTimeLabel.Text = TimeSpan.FromSeconds(progressTrackBar.Maximum).ToString(@"mm\:ss");

                
                displayArtist.Text = $"{song.Artist} - {song.Title}";
            }
            else
            {
                MessageBox.Show("No song found in the database.");
            }
        }
        private void LoadAndPlaySong()
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

                string filePath = song.FilePath;

                
                audioFileReader = new AudioFileReader(@filePath);

                
                waveOut.Init(audioFileReader);

                
                waveOut.Volume = volumeTrackBar.Value / 100f;

                
                volumeLabel.Text = $"Volume: {volumeTrackBar.Value}%";

                
                progressTrackBar.Minimum = 0;
                progressTrackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;

                
                totalTimeLabel.Text = TimeSpan.FromSeconds(progressTrackBar.Maximum).ToString(@"mm\:ss");

                
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
                playButton_Click(sender, e); 
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < totalSongs - 1)
            {
                currentSongIndex++;
                LoadAndPlaySong();
                playButton_Click(sender, e); 
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
            PlaylistManager mainForm = new PlaylistManager(currentUser);
            mainForm.Show();
            this.Hide(); 
        }
    }
}
