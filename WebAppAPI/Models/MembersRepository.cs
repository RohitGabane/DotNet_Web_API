
namespace WebAppAPI.Models
{
    public class MembersRepository : IMembers
    {
        List<Members> lisMembers = new List<Members>        
        {
            new Members{MemberId=1, FirstName="Kirtesh", LastName="Shah", Address="Mumbai" },
            new Members{MemberId=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Members{MemberId=3, FirstName="Dilip", LastName="Shah", Address="Banglore" },
            new Members{MemberId=4, FirstName="Atul", LastName="Shah", Address="Indore" },
            new Members{MemberId=5, FirstName="Swati", LastName="Shah", Address="Mumbai" },
            new Members{MemberId=6, FirstName="Rashmi", LastName="Shah", Address="Ahamdabad" },
         };

        public Members Add(Members member)
        {
            member.MemberId = lisMembers.Max(e => e.MemberId) + 1;
            lisMembers.Add(member);
            return member;

        }

        public Members Delete(int Id)
        {
            Members members = lisMembers.FirstOrDefault(e => e.MemberId == Id);
            if (members != null)
            {
                lisMembers.Remove(members);
            }
            return members;

        }

        public List<Members> GetAllMember()
        {
            return lisMembers;
        }

        public Members GetMember(int id)
        {
            return lisMembers.FirstOrDefault(x => x.MemberId == id);
        }

        public Members Update(int id, Members MembersChanges)
        {
            Members member = lisMembers.FirstOrDefault(e => e.MemberId == MembersChanges.MemberId);
            if (member != null)
            {
                member.FirstName = MembersChanges.FirstName;
                member.LastName = MembersChanges.LastName;
                member.Address = MembersChanges.Address;
            }
            return member;
        }

    }

}
