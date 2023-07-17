using SpeedList.Data;
using SpeedList.Models;

namespace SpeedList.Services;

public interface IMembersService
{
    List<Member> GetList();
}

public class MembersService : IMembersService
{
    public List<Member> GetList()
    {
        return MemberDataGenerator.GenerateList(100);
    }
}