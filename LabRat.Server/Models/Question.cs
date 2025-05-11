namespace LabRat.Server.Models;

public class Question
{
    public int QuestionId { get; set; }
    public string QuestionText { get; set; }
    public string CorrectAnswer { get; set; }
    public List<string> IncorrectAnswers { get; set; }
    public string QuestionTopic { get; set; }
    public string QuestionSubTopic { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public decimal DifficultyLevel { get; set; }
    public int TimesUsed { get; set; }
    public decimal SuccessRate { get; set; }
    //need to create an array that shuffles in the correct answer in a random order
    
}