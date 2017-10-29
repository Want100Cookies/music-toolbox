using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Music_Toolbox.Models;
using Newtonsoft.Json.Linq;

namespace Music_Toolbox.Screens
{
    public partial class RetrieveTorrent : Form
    {
        private List<Track> _backingTracks = new List<Track>();
        private BindingList<Track> _tracks;

        public RetrieveTorrent()
        {
            InitializeComponent();

            _tracks = new BindingList<Track>(_backingTracks); // Backing needed for sorting
            dataGrid_tracks.DataSource = _tracks;
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
           
        }

        private async JArray Search(string query, string indexer)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome / 58.0.3029.110 Safari / 537.36");

            UriBuilder builder = new UriBuilder("http://127.0.0.1:9117/api/v2.0/indexers/");
            builder.Path += indexer + "/results/torznab/";

            builder.Query += "apikey=" + "d02ug8nzuumncxq26xv8vwnq445nsa65" + "&";
            builder.Query += "t=search&";
            builder.Query += "q=" + Uri.EscapeDataString(query);

            string json = await client.DownloadStringTaskAsync(builder.Uri);
            return JArray.Parse(json);
        }
    }
}