using SpeedList.Views;

namespace SpeedList;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new MembersPage());
        await Shell.Current.GoToAsync($"//MembersPage");
    }
}

