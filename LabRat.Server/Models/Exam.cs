namespace LabRat.Server.Models;

public class Exam
{
    public int ExamId { get; set; }
    public User User { get; set; }
    public List<Question> Questions { get; set; }
    public decimal HematologyPercentage { get; set; }
    public decimal ChemistryPercentage { get; set; }
    public decimal ImmunologyPercentage { get; set; }
    public decimal MicrobiologyPercentage { get; set; }
    public decimal BloodBankPercentage { get; set; }
    public ExamType ExamType { get; set; }

    
}