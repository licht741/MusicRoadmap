using System.Collections.Generic;

namespace MusicRoadmap.Model
{
    public class Result
    {
        public Res results { get; set; }
    }

    public class Res
    {
        public ArtistSearchResult artistmatches { get; set; }
    }

    public class ArtistSearchResult
    {
        //public JToken artistmatches { get; set; }
        //public ArtistMatches artistmatches { get; set; }
        public List<Artist> artist { get; set; }
    }

    public class ArtistMatches
    {
        public List<Artist> artist { get; set; }
    }

    public class Artist
    {
        public Artist(string name, string listeners)
        {
            this.name = name;
            this.listeners = listeners;
        }

        public string name { get; set; }
        public string listeners { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
    }
}
