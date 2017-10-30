using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Argotic.Syndication;

namespace Music_Toolbox
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

        public void Search(string query, string indexer)
        {
            if (string.IsNullOrEmpty(query) || !Indexers.TryGetValue(indexer, out Uri indexerUri))
            {
                throw new ArgumentException();
            }

            Uri fullQuery = new Uri($"{indexerUri}?apikey={_apiKey}&t=search&q={query}");

            RssFeed feed = new RssFeed();
            WebClient client = new WebClient();
            XmlReader reader = XmlReader.Create(client.OpenRead(fullQuery) ?? throw new InvalidOperationException());
            feed.Load(reader);
            // Todo: fix navigatore null exception

            foreach (RssItem item in feed.Channel.Items)
            {
                Debug.Print(item.Title);
            }
        }
    }
}