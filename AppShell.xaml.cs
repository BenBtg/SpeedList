using SpeedList.Views;

namespace SpeedList;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MembersPage), typeof(MembersPage));
	}
}
