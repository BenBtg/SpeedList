using SpeedList.Data;
using SpeedList.Models;

namespace SpeedList.Services;

public interface IMembersService
{
    List<Member> GetMembers();
}

public class MembersService : IMembersService
{
    public List<Member> GetMembers()
    {
        return MemberDataGenerator.GenerateList(100);
    }
}