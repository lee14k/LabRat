namespace LabRat.Server.Models;

public class Question
{
    public int QuestionId { get; set; }
    public string QuestionText { get; set; }
    public string CorrectAnswer { get; set; }
    public List<string> Options { get; set; }
    
}