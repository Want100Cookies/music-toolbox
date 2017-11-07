using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTools.Xom;

namespace Music_Toolbox.Jackett
{
    class Item
    {
        public string Title { get; }
        public Uri Link { get; }
        public int Size { get; }
        public string Magnet { get; }
        public int Seeders { get; }
        public int Leechers { get; }

        public Item(string title, Uri link, int size, string magnet, int seeders, int leechers)
        {
            Title = title;
            Link = link;
            Size = size;
            Magnet = magnet;
            Seeders = seeders;
            Leechers = leechers;
        }

        public static Item FromElement(Element element)
        {
            return new Item(
                element["title"][0].StringValue,
                new Uri(element["guid"][0].StringValue), 
                element["size"][0].IntValue,
                element["link"][0].StringValue,
                element["torznab:attr"].
                );
        }
    }
}

//<item>
//            <title>BULLET FOR MY VALENTINE - DISCOGRAPHY[CHANNEL NEO]</title>
//            <guid>https://thepiratebay.org/torrent/8114720/BULLET_FOR_MY_VALENTINE_-_DISCOGRAPHY_[CHANNEL_NEO]</guid>
//            <comments>https://thepiratebay.org/torrent/8114720/BULLET_FOR_MY_VALENTINE_-_DISCOGRAPHY_[CHANNEL_NEO]</comments>
//            <pubDate>Thu, 07 Feb 2013 00:00:00 +0100</pubDate>
//            <size>758770560</size>
//            <description />
//            <link>magnet:? xt = urn:btih:d43330fbed16ff1954be317ea69589bd375e7e05&amp;dn=BULLET+FOR+MY+VALENTINE+-+DISCOGRAPHY+[CHANNEL+NEO]&amp;tr=udp:%2F%2Ftracker.leechers-paradise.org:6969&amp;tr=udp:%2F%2Fzer0day.ch:1337&amp;tr=udp:%2F%2Fopen.demonii.com:1337&amp;tr=udp:%2F%2Ftracker.coppersurfer.tk:6969&amp;tr=udp:%2F%2Fexodus.desync.com:6969</link>
//            <category>3000</category>
//            <category>100101</category>
//            <enclosure url = "magnet:?xt=urn:btih:d43330fbed16ff1954be317ea69589bd375e7e05&amp;dn=BULLET+FOR+MY+VALENTINE+-+DISCOGRAPHY+[CHANNEL+NEO]&amp;tr=udp:%2F%2Ftracker.leechers-paradise.org:6969&amp;tr=udp:%2F%2Fzer0day.ch:1337&amp;tr=udp:%2F%2Fopen.demonii.com:1337&amp;tr=udp:%2F%2Ftracker.coppersurfer.tk:6969&amp;tr=udp:%2F%2Fexodus.desync.com:6969" length="758770560" type="application/x-bittorrent" />
//            <torznab:attr name = "category" value="3000" />
//            <torznab:attr name = "category" value="100101" />
//            <torznab:attr name = "magneturl" value="magnet:?xt=urn:btih:d43330fbed16ff1954be317ea69589bd375e7e05&amp;dn=BULLET+FOR+MY+VALENTINE+-+DISCOGRAPHY+[CHANNEL+NEO]&amp;tr=udp:%2F%2Ftracker.leechers-paradise.org:6969&amp;tr=udp:%2F%2Fzer0day.ch:1337&amp;tr=udp:%2F%2Fopen.demonii.com:1337&amp;tr=udp:%2F%2Ftracker.coppersurfer.tk:6969&amp;tr=udp:%2F%2Fexodus.desync.com:6969" />
//            <torznab:attr name = "seeders" value="45" />
//            <torznab:attr name = "peers" value="54" />
//            <torznab:attr name = "minimumratio" value="1" />
//            <torznab:attr name = "minimumseedtime" value="172800" />
//            <torznab:attr name = "downloadvolumefactor" value="0" />
//            <torznab:attr name = "uploadvolumefactor" value="1" />
//        </item>