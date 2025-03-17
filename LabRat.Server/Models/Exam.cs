namespace LabRat.Server.Models;

public class Exam
{
    public int ExamId { get; set; }
    public User User { get; set; }
    public List<Question> Questions { get; set; }
    
}