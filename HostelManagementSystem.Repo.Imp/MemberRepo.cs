using System.Collections.Generic;
using System.Linq;
using HostelManagementSystem.Data;
using HostelManagementSystem.Entity;
namespace HostelManagementSystem.Repo.Imp
{
    public class MemberRepo : IMemberRepo
    {
        private MealCalculationDBContext context = new MealCalculationDBContext();
        public List<Member> GetAll()
        {
            var result = new List<Member>();
            result = context.Members.ToList();
            return result;
        }

        public Member Get(int id)
        {
            var result = new Member();
            result = context.Members.FirstOrDefault(a => a.ID == id);
            return result;
        }

        public int AddMember(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();

            return member.ID;
        }

        public List<string> GetMembersName()
        {
            var result = context.Members.ToList();
            List<string> Name = new List<string>();
            foreach (var x in result)
                Name.Add(x.Name);

            return Name;
        }
    }
}
