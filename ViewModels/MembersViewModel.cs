using CommunityToolkit.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using SpeedList.Models;
using SpeedList.Services;

namespace SpeedList.ViewModels
{
    public partial class MembersViewModel : ObservableObject
    {
        private readonly IMembersService _memberService;

        [ObservableProperty]
        private List<Member> _members;


        public MembersViewModel()
        {
            _memberService = new MembersService();
            LoadContacts();
        }

        public void LoadContacts()
        {
            Members = _memberService.GetList();
        }
    }
}
