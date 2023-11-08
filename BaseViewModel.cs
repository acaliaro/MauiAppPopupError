using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiAppPopupError
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy;

        LoadingView _loadingView;

        partial void OnIsBusyChanged(bool value)
        {
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                try
                {

                    if (value)
                    {
                        if(_loadingView == null)
                            _loadingView = new LoadingView();
                        
                        await Shell.Current.CurrentPage.ShowPopupAsync<LoadingView>(_loadingView);
                    }
                    else
                    {
                        if (_loadingView != null)
                        {
                            await _loadingView.CloseAsync();
                            _loadingView = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });

        }
    }
}
