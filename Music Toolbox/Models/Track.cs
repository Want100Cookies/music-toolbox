using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IF.Lastfm.Core.Api.Helpers;
using Newtonsoft.Json.Linq;

namespace Music_Toolbox.Models
{
    public class Track
    {
        public string TrackName { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int NoPlays { get; set; }
//        public JArray Torrents { get; set; }
    }
}