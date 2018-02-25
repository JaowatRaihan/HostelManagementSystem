using HostelManagementSystem.Entity;
using System.Collections.Generic;

namespace HostelManagementSystem.Repo
{
    public interface IMemberRepo
    {
        List<Member> GetAll();
        Member Get(int id);
        int AddMember(Member member);
        List<string> GetMembersName();
    }
}
