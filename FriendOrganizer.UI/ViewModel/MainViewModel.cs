
using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationViewModel _navigationViewModel;

        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            _navigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await _navigationViewModel.LoadAsync();

        }


    }

}
