using SpeedList.Data;
using SpeedList.Models;

namespace SpeedList.Services;

public interface IMembersService
{
    List<Member> GetMembers(int count);
}

public class MembersService : IMembersService
{
    public List<Member> GetMembers(int count)
    {
        return MemberDataGenerator.GenerateList(count);
    }
}