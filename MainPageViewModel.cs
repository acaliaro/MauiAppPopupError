using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPopupError
{
    public partial class MainPageViewModel : BaseViewModel
    {

        [RelayCommand]
        async Task OpenPopupAsync()
        {
            try
            {
                IsBusy = true;
                await Task.Delay(2000);
                await Shell.Current.GoToAsync(nameof(NewPage1));
            }
            catch { }
            finally { IsBusy = false; }
        }
    }
}
