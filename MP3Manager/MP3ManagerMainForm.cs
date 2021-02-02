using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MP3Manager
{
    public partial class MP3Manager : Form
    {
        public MP3Manager()
        {
            InitializeComponent();
        }

        List<string> RunLispProcess(string func, List<string> argsList)
        {
            string args = "";
            foreach (string arg in argsList)
            {
                args += " \"" + arg + "\"";
            }
            return RunLispProcess(func + args);
        }

        List<string> RunLispProcess(string args)
        {
            List<string> res = new List<string>();

            Process lispProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "clisp",
                    Arguments = "main.lisp " + args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            lispProcess.Start();
            
            while (!lispProcess.StandardOutput.EndOfStream)
            {
                res.Add(lispProcess.StandardOutput.ReadLine());
            }
            
            return res;
        }

        private void MP3Manager_Load(object sender, EventArgs e)
        {
            loadPlaylists();
            loadSongs();
        }

        private void loadPlaylists()
        {
            List<string> playlists = RunLispProcess("get-playlists");
            playlistsListBox.Items.Clear();
            foreach (string playlist in playlists)
            {
                playlistsListBox.Items.Add(playlist);
            }
        }

        private void loadFilteredPlaylists(string keyword)
        {
            List<string> playlists = RunLispProcess("filter-playlists", new List<string>() { keyword });
            playlistsListBox.Items.Clear();
            foreach (string playlist in playlists)
            {
                playlistsListBox.Items.Add(playlist);
            }
        }

        private void loadSongs()
        {
            List<string> songs = RunLispProcess("get-songs");
            songsCheckedListBox.Items.Clear();
            foreach (string song in songs)
            {
                songsCheckedListBox.Items.Add(song);
            }
        }

        private void loadFilteredSongs(string keyword)
        {
            List<string> songs = RunLispProcess("filter-songs", new List<string>() { keyword });
            songsCheckedListBox.Items.Clear();
            foreach (string song in songs)
            {
                songsCheckedListBox.Items.Add(song);
            }
        }

        private void loadSelectedPlaylistSongs()
        {
            List<string> songs = RunLispProcess("get-playlist-songs", new List<string>() { playlistsListBox.SelectedItem.ToString() });
            selectedPlaylistSongsCheckedListBox.Items.Clear();
            foreach (string song in songs)
            {
                selectedPlaylistSongsCheckedListBox.Items.Add(song);
            }
        }
        private void loadSelectedPlaylistFilteredSongs(string keyword)
        {
            List<string> songs = RunLispProcess("filter-songs-in-playlist", new List<string>() { playlistsListBox.SelectedItem.ToString(), keyword });
            selectedPlaylistSongsCheckedListBox.Items.Clear();
            foreach (string song in songs)
            {
                selectedPlaylistSongsCheckedListBox.Items.Add(song);
            }
        }

        private void playlistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playlistsListBox.SelectedIndex != -1)
            {
                selectedPlaylistGroupBox.Text = playlistsListBox.SelectedItem.ToString();
                loadSelectedPlaylistSongs();
            }
        }

        private void playlistsNewButton_Click(object sender, EventArgs e)
        {
            RunLispProcess("create-new-playlist", new List<string>() { playlistsNewTextBox.Text });
            loadPlaylists();
            playlistsNewTextBox.Text = "";
        }

        private void playlistsNewTextBox_TextChanged(object sender, EventArgs e)
        {
            if (playlistsNewTextBox.Text != "")
            {
                playlistsNewButton.Enabled = true;
            }
            else
            {
                playlistsNewButton.Enabled = false;
            }
        }

        private void playlistsSearchPictureBox_Click(object sender, EventArgs e)
        {
            if (playlistsSearchTextBox.Text != "")
            {
                loadFilteredPlaylists(playlistsSearchTextBox.Text);
            }
            else
            {
                loadPlaylists();
            }
        }

        private void songsSearchPictureBox_Click(object sender, EventArgs e)
        {
            if (songsSearchTextBox.Text != "")
            {
                loadFilteredSongs(songsSearchTextBox.Text);
            }
            else
            {
                loadSongs();
            }
        }

        private void loadSelectedPlaylistSongsList()
        {
            if (selectedPlaylistSearchTextBox.Text != "")
            {
                loadSelectedPlaylistFilteredSongs(selectedPlaylistSearchTextBox.Text);
            }
            else
            {
                loadSelectedPlaylistSongs();
            }
        }

        private void selectedPlaylistSearchPictureBox_Click(object sender, EventArgs e)
        {
            loadSelectedPlaylistSongsList();
        }

        private void songsAddToPlaylistButton_Click(object sender, EventArgs e)
        {
            if (songsCheckedListBox.CheckedItems.Count > 0 && playlistsListBox.SelectedIndex != -1)
            {
                List<string> argsList = new List<string>() { playlistsListBox.SelectedItem.ToString() };
                foreach (string selectedSong in songsCheckedListBox.CheckedItems)
                {
                    argsList.Add(selectedSong);
                }
                RunLispProcess("put-songs-in-playlist", argsList);
                loadSelectedPlaylistSongsList();
            }
        }

        private void selectedPlaylistDeleteSongButton_Click(object sender, EventArgs e)
        {
            if (selectedPlaylistSongsCheckedListBox.SelectedIndex != -1)
            {
                List<string> argsList = new List<string>() { playlistsListBox.SelectedItem.ToString() };
                foreach (int selectedSong in selectedPlaylistSongsCheckedListBox.CheckedIndices)
                {
                    argsList.Add(selectedSong.ToString());
                }
                RunLispProcess("remove-songs-from-playlist", argsList);
                loadSelectedPlaylistSongsList();
            }
        }

        private void selectedPlaylistMoveSongDownButton_Click(object sender, EventArgs e)
        {
            if (selectedPlaylistSongsCheckedListBox.SelectedIndex != -1)
            {
                int selectedIndex = selectedPlaylistSongsCheckedListBox.SelectedIndex;
                RunLispProcess("move-song-down-in-playlist", new List<string>() {
                    playlistsListBox.SelectedItem.ToString(),
                    selectedPlaylistSongsCheckedListBox.SelectedIndex.ToString()
                });
                loadSelectedPlaylistSongsList();
                selectedPlaylistSongsCheckedListBox.SelectedIndex = Math.Min(selectedIndex + 1, selectedPlaylistSongsCheckedListBox.Items.Count - 1);
            }
        }

        private void selectedPlaylistMoveSongUpButton_Click(object sender, EventArgs e)
        {
            if (selectedPlaylistSongsCheckedListBox.SelectedIndex != -1)
            {
                int selectedIndex = selectedPlaylistSongsCheckedListBox.SelectedIndex;
                RunLispProcess("move-song-up-in-playlist", new List<string>() {
                    playlistsListBox.SelectedItem.ToString(),
                    selectedPlaylistSongsCheckedListBox.SelectedIndex.ToString()
                });
                loadSelectedPlaylistSongsList();
                selectedPlaylistSongsCheckedListBox.SelectedIndex = Math.Max(selectedIndex - 1, 0);
            }
        }

        private void selectedPlaylistSongsCheckedListBox_DoubleClick(object sender, EventArgs e)
        {
            if (selectedPlaylistSongsCheckedListBox.SelectedIndex != -1)
            {
                Player player = new Player(selectedPlaylistSongsCheckedListBox.SelectedItem.ToString());
                player.Show();
            }
        }

        private void songsCheckedListBox_DoubleClick(object sender, EventArgs e)
        {
            if (songsCheckedListBox.SelectedIndex != -1)
            {
                Player player = new Player(songsCheckedListBox.SelectedItem.ToString());
                player.Show();
            }
        }
    }
}
