using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using xTools.Xom;

namespace Music_Toolbox.Jackett
{
    public class JackettSearcher
    {
        public Dictionary<string, Uri> Indexers { get; }
        private readonly string _apiKey;

        public JackettSearcher(string apiKey)
        {
            Indexers = new Dictionary<string, Uri>();
            _apiKey = apiKey;
        }

        public void AddIndexer(string name, Uri uri)
        {
            Indexers.Add(name, uri);
        }

        public bool RemoveIndexer(string name)
        {
            return Indexers.Remove(name);
        }

        public void Search(string query)
        {
            foreach (KeyValuePair<string, Uri> indexer in Indexers)
            {
                Search(query, indexer.Key);
            }
        }

        public async void Search(string query, string indexer)
        {
            if (string.IsNullOrEmpty(query) || !Indexers.TryGetValue(indexer, out Uri indexerUri))
            {
                throw new ArgumentException();
            }

            Uri fullQuery = new Uri($"{indexerUri}?apikey={_apiKey}&t=search&q={query}");

            WebClient webClient = new WebClient();
            string xml = await webClient.DownloadStringTaskAsync(fullQuery);
            Element rss = Element.Parse(xml);
            Element channel = rss[0];

            foreach (Element item in channel["item"])
            {
                string title = item["title"][0].StringValue;
                string url = item["guid"][0].StringValue;
                string magnet = item["link"][0].StringValue;
            }

        }
    }
}