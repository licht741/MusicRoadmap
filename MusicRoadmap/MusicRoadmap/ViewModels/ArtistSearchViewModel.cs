using MusicRoadmap.Model;
using MusicRoadmap.Services;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace MusicRoadmap.Core
{
    public class ArtistSearchViewModel : MvxViewModel
    {
        readonly IMusicService _calculation;

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        MvxObservableCollection<Artist> artists;

        public MvxObservableCollection<Artist> Artists
        {
            get
            {
                artists = new MvxObservableCollection<Artist>(_calculation.GetArtists("a").Result);
                return artists;
            }

            set
            {
                artists.Clear();
                artists.AddRange(value);
            }
        }


        private string _searchString;
        public string SearchString
        {
            get
            {
                return _searchString;
            }

            set
            {
                _searchString = value;
                refind();
            }
        }

        /// <summary>
        /// Use constructor injection to supply _calculation with the implementation.
        /// </summary>
        public ArtistSearchViewModel(IMusicService calculation)
        {
            _calculation = calculation;
        }

        void refind()
        {
            Artists = new MvxObservableCollection<Artist>(_calculation.GetArtists(SearchString).Result);
        }
    }
}
