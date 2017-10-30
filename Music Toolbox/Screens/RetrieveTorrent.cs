using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Music_Toolbox.Models;
using Newtonsoft.Json.Linq;

namespace Music_Toolbox.Screens
{
    public partial class RetrieveTorrent : Form
    {
        private List<Track> _backingTracks = new List<Track>();
        private BindingList<Track> _tracks;
        private readonly IApiKeys _apiKeys = new ApiKeys();
        private JackettSearcher _searcher;

        public RetrieveTorrent()
        {
            InitializeComponent();

            _tracks = new BindingList<Track>(_backingTracks); // Backing needed for sorting
            dataGrid_tracks.DataSource = _tracks;

            _searcher = new JackettSearcher(_apiKeys.GetJackettApiKey());
            _searcher.AddIndexer("The Pirate Bay", new Uri("http://127.0.0.1:9117/api/v2.0/indexers/thepiratebay/results/torznab/"));

        }

        private void btn_load_playlist_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Playlist file|*.xml",
                Title = "Open playlist file"
            };

            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.FileName)) return;

            Stream fs = dialog.OpenFile();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Track>));
            _backingTracks.Clear();
            _backingTracks.InsertRange(0, (List<Track>) serializer.Deserialize(fs));
            _tracks.ResetBindings();

            fs.Close();
        }

        private async void btn_magnet_Click(object sender, EventArgs e)
        {
            if (_tracks.Count == 0) return;

            Track track = _tracks.First();
            string query = $"{track.AlbumName} {track.ArtistName}";

            _searcher.Search(query);
        }

        
    }
}