using MusicRoadmap.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicRoadmap.Services
{
    public interface IMusicService
    {
        Task<List<Artist>> GetArtists(string artist);
    }
}
