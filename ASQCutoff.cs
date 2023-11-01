namespace DemoASQ.API.Data.Entities;

public class ASQCutoff
{
    public int Id { get; set; }
    public string TestType { get; set; } = string.Empty;
    public double Communication { get; set; }
    public double GrossMotor { get; set; }
    public double FineMotor { get; set; }
    public double ProblemSolving { get; set; }
    public double PersonalSocial { get; set; }
}
