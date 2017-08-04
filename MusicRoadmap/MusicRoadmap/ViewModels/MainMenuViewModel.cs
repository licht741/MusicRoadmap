using MusicRoadmap.Core;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MusicRoadmap.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        public ICommand NavigateCreateBill
        {
            get { return new MvxCommand(() => ShowViewModel<ArtistSearchViewModel>(new { subTotal = 40 })); }
        }
    }
}
