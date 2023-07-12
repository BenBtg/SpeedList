using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
