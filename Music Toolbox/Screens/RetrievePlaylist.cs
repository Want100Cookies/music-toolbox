using IF.Lastfm.Core.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using IF.Lastfm.Core.Api.Helpers;
using IF.Lastfm.Core.Objects;
using Music_Toolbox.Models;

namespace Music_Toolbox.Screens
{
    public partial class RetrievePlaylist : Form
    {
        private readonly LastfmClient _client;
        private List<Track> _backingTracks = new List<Track>();
        private BindingList<Track> _tracks;

        public RetrievePlaylist()
        {
            InitializeComponent();

            IApiKeys apiKeys = new ApiKeys();
            _client = new LastfmClient(apiKeys.GetLastfmApiKey(), apiKeys.GetLastfmApiSecret());

            _tracks = new BindingList<Track>(_backingTracks); // Backing needed for sorting
            dataGrid_recent.DataSource = _tracks;
        }

        private async void btn_retrieve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_client.Auth.ApiKey))
            {
                MessageBox.Show("LastFm API does not have a valid api key!");
                return;
            }

            string username = txt_username.Text;
            int months = (int) num_months.Value;

            int nextPage = 1;
            int totalPages = 0;
            const int count = 200; // 50 default; 200 max

            do
            {
                PageResponse<LastTrack> recent = await _client.User.GetRecentScrobbles(
                    username,
                    DateTimeOffset.Now.AddMonths(-1 * months), nextPage,
                    count
                );

                foreach (LastTrack recentTrack in recent)
                {
                    if (_tracks.Count(track => track.TrackName == recentTrack.Name) == 0)
                    {
                        _tracks.Add(new Track
                        {
                            TrackName = recentTrack.Name,
                            ArtistName = recentTrack.ArtistName,
                            AlbumName = recentTrack.AlbumName,
                            TimePlayed = recentTrack.TimePlayed.ToString(),
                            NoPlays = 1
                        });
                    }
                    else
                    {
                        _tracks.First(track => track.TrackName == recentTrack.Name).NoPlays++;
                    }
                }

                nextPage = recent.Page + 1;
                totalPages = recent.TotalPages;

                progressbar.Value = (int) Math.Round((double) (100 * recent.Page) / (recent.TotalPages));
            } while (nextPage - 1 != totalPages);

            // Sort the backing list then reset binding in the binding list
            _backingTracks.Sort((x, y) => string.Compare(x.TrackName, y.TrackName, StringComparison.Ordinal));
            _tracks.ResetBindings();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_tracks == null || _tracks.Count == 0)
            {
                MessageBox.Show("Can't export empty playlist!");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Playlist File|*.xml",
                Title = "Save playlist to file"
            };

            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.FileName)) return;

            Stream fs = dialog.OpenFile();

            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Track>));
            serializer.Serialize(fs, dataGrid_recent.DataSource);

            fs.Close();
        }
    }
}