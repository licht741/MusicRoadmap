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
        public String mbid { get; set; }
        public Tags tags { get; set; }
        public Bio bio { get; set; }
    }

    public class Tags
    {
        public List<Tag> tag { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
