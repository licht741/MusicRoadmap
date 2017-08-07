using MusicRoadmap.Core;
using MusicRoadmap.Model;
using MusicRoadmap.Services;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MusicRoadmap.ViewModels
{
    class ArtistDetailsViewModel: MvxViewModel
    {
        IMusicService _calculation;
        public ArtistDetails Details;

        public ArtistDetailsViewModel(IMusicService calculation)
        {
            _calculation = calculation;

        }

        public class Nav
        {
            public string Id { get; set; }
        }

        public async void Init(Nav navigation)
        {
            Details = await _calculation.GetArtistDetails(navigation.Id);
        }

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<ArtistSearchViewModel>(new ArtistSearchViewModel.Nav()));
            }
        }

        public string Name
        {
            get { return Details.name; }
            set { Details.name = value; }
        }

        public string Summary
        {
            get { return Details.bio.summary; }
            set { Details.bio.summary = value; }
        }

        public string Image
        {
            get
            {
                return @"https://www.w3schools.com/css/img_fjords.jpg";
            }

            set
            {

            }
        }

        public string Published
        {
            get { return Details.bio.published; }
            set { Details.bio.published = value; }
        }
    }
}
