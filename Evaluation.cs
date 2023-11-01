namespace DemoASQ.API.Data.Entities;

public class Evaluation
{
    public int Id { get; set; }
    public string TestType { get; set; } = string.Empty;
    public string ChildFirstName { get; set; } = string.Empty;
    public string ChildLastName { get; set; } = string.Empty;
    public int CommunicationScore { get; set; }
    public int GrossMotorScore { get; set; }
    public int FineMotorScore { get; set; }
    public int ProblemSolvingScore { get; set; }
    public int PersonalSocialScore { get; set; }
}
