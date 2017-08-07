using MusicRoadmap.Model;
using MusicRoadmap.Services;
using MusicRoadmap.ViewModels;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace MusicRoadmap.Core
{
    public class ArtistSearchViewModel : MvxViewModel
    {
        readonly IMusicService _calculation;

        //public ICommand NavBack
        //{
        //    get
        //    {
        //        return new MvxCommand(() => Close(this));
        //    }
        //}

        public class Nav
        {
        }

        public void Init(Nav navigation)
        {
            
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
    

    private MvxCommand<ArtistSearchViewModel> _memoryClickedCommand = null;
    public ICommand MemoryClickedCommand
        {
            get
            {
                return new MvxCommand<Artist>(item =>
                {
                    ShowViewModel<ArtistDetailsViewModel>(new ArtistDetailsViewModel.Nav() { Id = item.mbid });
                });

                //if (_memoryClickedCommand == null)
                //    _memoryClickedCommand = new MvxCommand<ArtistSearchViewModel>(artist =>
                //    {
                        
                //    });

                //return _memoryClickedCommand;

                //return _memoryClickedCommand = _memoryClickedCommand ?? new MvxCommand<ArtistSearchViewModel>(memory => {
                //    int tmp = 0;
                //    });
            }

            set
            {
                _memoryClickedCommand = value as MvxCommand<ArtistSearchViewModel>;
            }
        }

    }
}
