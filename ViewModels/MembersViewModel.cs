using CommunityToolkit.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using SpeedList.Models;
using SpeedList.Services;
using System.Collections.ObjectModel;

namespace SpeedList.ViewModels
{
    public partial class MembersViewModel : BaseViewModel
    {
        private readonly IMembersService _memberService;

        [ObservableProperty]
        private ObservableCollection<Member> _members = new ObservableCollection<Member>();

        public MembersViewModel()
        {
           _memberService = new MembersService();     
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
                    var memberList = _memberService.GetMembers();
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
}
