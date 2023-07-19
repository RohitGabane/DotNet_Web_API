namespace WebAppAPI.Models
{
    public interface IMembers
    {
        List<Members> GetAllMember();
        Members GetMember(int id);
        Members Add(Members member);
        Members Update(int id, Members MembersChanges);
        Members Delete(int Id);

    }
}
