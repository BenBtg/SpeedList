using CommunityToolkit.Mvvm.ComponentModel;

namespace SpeedList.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        public virtual void OnAppearing()
        {

        }

        public virtual void OnNavigatedTo(NavigatedToEventArgs args)
        {

        }
    }
}
