namespace SpeedList.ViewModels;

[QueryProperty(nameof(Length), nameof(Length))]
public partial class MembersViewModel : BaseViewModel
{
    private readonly IMembersService _memberService;

    [ObservableProperty]
    private ObservableCollection<Member> _members = new ObservableCollection<Member>();

    [ObservableProperty]
    int length;

    public MembersViewModel(IMembersService membersService)
    {
        _memberService = membersService;
    }

    override public void OnAppearing()
    {
        base.OnAppearing();
        LoadContacts();
    }

    public void LoadContacts()
    {
        Task.Run(async () =>
        {
            try
            {
                Members.Clear();
                var memberList = _memberService.GetMembers(Length);
                foreach (var member in memberList)
                {
                    Members.Add(member);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
        });
    }
}