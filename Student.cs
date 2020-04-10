public class Student : Person
{
    public string StudentId { get; set; }
    public string Email { get; set; }

    public Student(string Name, int Age, string StudentId, string Email): base(Name,Age)
    {
        this.Name = Name;
        this.Age = Age;
        this.StudentId = StudentId;
        this.Email = Email;
    }
}