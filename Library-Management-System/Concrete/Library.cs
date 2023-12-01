using Library_Management_System.Abstract;

namespace Library_Management_System.Concrete
{
    internal static class Library
    {
        internal static List<Publication> publications = new();
        internal static List<Member> members = new();

        internal static void AddPublication(Publication publication)
        {
            publications.Add(publication);
        }
        internal static void AddMember(Member member)
        {
            members.Add(member);
        }
        internal static void DeletePublication(Publication publication)
        {
            publications.Remove(publication);
        }
        internal static void DeleteMember(Member member)
        {
            members.Remove(member);
        }
        internal static void Borrow(Member member, Publication publication)
        {
            member.Borrow(publication);
            publications.Remove(publication);
        }
        internal static void Return(Member member, Publication publication)
        {
            member.Return(publication);
            publications.Add(publication);
        }
    }
}
