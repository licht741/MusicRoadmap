using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;

namespace MusicRoadmap.Model
{
    public class ArtistDetailsWrapper
    {
        public ArtistDetails artist { get; set; }
    }

    public class ArtistDetails
    {
        public String name { get; set; }
        [PrimaryKey]
        public String mbid { get; set; }
        public Tags tags { get; set; }
        public Bio bio { get; set; }
    }

    public class Tags
    {
        [PrimaryKey, AutoIncrement]
        public long id { get; set; }


        public List<Tag> tag { get; set; }
    }

    public class Tag
    {
        [PrimaryKey, AutoIncrement]
        public long id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
