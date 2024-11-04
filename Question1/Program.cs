using Question1;

internal class Program
{
    private static void Main(string[] args)
    {
        Teacher teacher = new Teacher { Id = 1, Name = "Teacher 1", Skill = ".Net" };
        Student student1 = new Student { Id = 2, Name = "Student A", Dob = new DateOnly(2000, 12, 23) };
        Student student2 = new Student { Id = 3, Name = "Student B", Dob = new DateOnly(2000, 5, 16) };
        MemberList memberList = new MemberList();
        memberList.MaximumNumberOfMember = 3;
        memberList.OnFullOfMember += OnFullOfMemberNotify;
        memberList.Add(student1);
        memberList.Add(student2);
        memberList.Add(teacher);
        Console.WriteLine(Environment.NewLine);
        memberList.DisplayList();

        Console.WriteLine(Environment.NewLine);
        ICustomList customList = new MemberList();
        customList.Add(new Student { Id = 4, Name = "Student C", Dob = new DateOnly(2000, 12, 25) });
        customList.Add(new Student { Id = 5, Name = "Student D", Dob = new DateOnly(2000, 12, 25) });
        customList.DisplayList();

    }

    private static void OnFullOfMemberNotify()
    {
        Console.WriteLine("The member list is full");
    }
}
