using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MusicRoadmap.Model;
using System.Net.Http;
using Newtonsoft.Json;

namespace MusicRoadmap.Services
{
    class MusicService: IMusicService
    {
        public async Task<List<Artist>> GetArtists(string artist)
        {
            var uri = "http://ws.audioscrobbler.com/2.0/?method=artist.search&artist=" + artist + "&api_key=43fa614bc0b7a0df426a969eee4db52a&format=json&limit=50";

            var response = new HttpClient().GetAsync(uri);
            var content = await response.Result.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Result>(content);
            return result.results.artistmatches.artist;
        }

        public async Task<ArtistDetails> GetArtistDetails(string mbid)
        {
            var uri = "http://ws.audioscrobbler.com/2.0/?method=artist.getinfo&mbid=" + mbid + "&api_key=43fa614bc0b7a0df426a969eee4db52a&format=json";
            var response = new HttpClient().GetAsync(uri);
            var content = await response.Result.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ArtistDetailsWrapper>(content);

            return result.artist;
        }
    }
}
