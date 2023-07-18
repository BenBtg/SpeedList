using SpeedList.ViewModels;

namespace SpeedList.Views;

public partial class MembersPage : BasePage
{
	public MembersPage(MembersViewModel membersViewModel)
	{
		InitializeComponent();
		BindingContext = membersViewModel;
	}
}