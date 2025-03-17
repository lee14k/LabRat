namespace LabRat.Server.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string MembershipType { get; set; }
    public List<Exam> Exams { get; set; }
}