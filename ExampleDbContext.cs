using DemoASQ.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoASQ.API.Data.Context;

public class DemoASQDbContext : DbContext
{
    public DemoASQDbContext(DbContextOptions<DemoASQDbContext> options) : base(options)
    {
    }

    public DbSet<Evaluation> Evaluations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Evaluation>().HasData(new Evaluation
        {
            Id = 1,
            TestType = "ASQ-3",
            ChildFirstName = "Bryce",
            ChildLastName = "McDonald",
            CommunicationScore = 25,
            GrossMotorScore = 30,
            FineMotorScore = 35,
            ProblemSolvingScore = 40,
            PersonalSocialScore = 45
        });
        modelBuilder.Entity<Evaluation>().HasData(new Evaluation
        {
            Id = 2,
            TestType = "ASQ-3",
            ChildFirstName = "Conrad",
            ChildLastName = "Johnson",
            CommunicationScore = 50,
            GrossMotorScore = 55,
            FineMotorScore = 60,
            ProblemSolvingScore = 65,
            PersonalSocialScore = 70
        });
        modelBuilder.Entity<Evaluation>().HasData(new Evaluation
        {
            Id = 3,
            TestType = "ASQ-3",
            ChildFirstName = "Sam",
            ChildLastName = "Smith",
            CommunicationScore = 75,
            GrossMotorScore = 80,
            FineMotorScore = 85,
            ProblemSolvingScore = 90,
            PersonalSocialScore = 95
        });
        modelBuilder.Entity<Evaluation>().HasData(new Evaluation
        {
            Id = 4,
            TestType = "ASQ-3",
            ChildFirstName = "Stephen",
            ChildLastName = "King",
            CommunicationScore = 100,
            GrossMotorScore = 105,
            FineMotorScore = 110,
            ProblemSolvingScore = 115,
            PersonalSocialScore = 120
        });
        modelBuilder.Entity<Evaluation>().HasData(new Evaluation
        {
            Id = 5,
            TestType = "ASQ-3",
            ChildFirstName = "Adam",
            ChildLastName = "Sandler",
            CommunicationScore = 55,
            GrossMotorScore = 21,
            FineMotorScore = 18,
            ProblemSolvingScore = 34,
            PersonalSocialScore = 65
        });

        // cutoff
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            Id = 1,
            TestType = "2 Month",
            Communication = 22.77,
            GrossMotor = 41.84,
            FineMotor = 30.16,
            ProblemSolving = 24.62,
            PersonalSocial = 33.71
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "4 Month",
            Id = 2,
            Communication = 34.6,
            GrossMotor = 38.41,
            FineMotor = 29.62,
            ProblemSolving = 34.98,
            PersonalSocial = 33.16
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "6 Month",
            Id = 3,
            Communication = 29.65,
            GrossMotor = 22.25,
            FineMotor = 25.14,
            ProblemSolving = 27.72,
            PersonalSocial = 25.34
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "8 Month",
            Id = 4,
            Communication = 33.06,
            GrossMotor = 30.61,
            FineMotor = 40.15,
            ProblemSolving = 36.17,
            PersonalSocial = 35.84
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "9 Month",
            Id = 5,
            Communication = 13.97,
            GrossMotor = 17.82,
            FineMotor = 31.32,
            ProblemSolving = 28.72,
            PersonalSocial = 18.91
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "10 Month",
            Id = 6,
            Communication = 22.87,
            GrossMotor = 30.07,
            FineMotor = 37.97,
            ProblemSolving = 32.51,
            PersonalSocial = 27.25
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "12 Month",
            Id = 7,
            Communication = 15.64,
            GrossMotor = 21.49,
            FineMotor = 34.5,
            ProblemSolving = 27.32,
            PersonalSocial = 21.73
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "14 Month",
            Id = 8,
            Communication = 17.4,
            GrossMotor = 25.8,
            FineMotor = 23.06,
            ProblemSolving = 22.56,
            PersonalSocial = 23.18
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "6 Month",
            Id = 9,
            Communication = 16.81,
            GrossMotor = 37.91,
            FineMotor = 37.98,
            ProblemSolving = 30.51,
            PersonalSocial = 26.43
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "18 Month",
            Id = 10,
            Communication = 13.06,
            GrossMotor = 37.38,
            FineMotor = 34.32,
            ProblemSolving = 25.74,
            PersonalSocial = 27.19
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "20 Month",
            Id = 11,
            Communication = 20.5,
            GrossMotor = 39.89,
            FineMotor = 36.05,
            ProblemSolving = 28.84,
            PersonalSocial = 33.36
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "22 Month",
            Id = 12,
            Communication = 13.04,
            GrossMotor = 27.75,
            FineMotor = 29.61,
            ProblemSolving = 29.3,
            PersonalSocial = 30.07
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "24 Month",
            Id = 13,
            Communication = 25.17,
            GrossMotor = 38.07,
            FineMotor = 35.16,
            ProblemSolving = 29.78,
            PersonalSocial = 31.54
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "27 Month",
            Id = 14,
            Communication = 24.02,
            GrossMotor = 28.01,
            FineMotor = 18.42,
            ProblemSolving = 27.62,
            PersonalSocial = 25.31
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "30 Month",
            Id = 15,
            Communication = 33.3,
            GrossMotor = 36.14,
            FineMotor = 19.25,
            ProblemSolving = 27.08,
            PersonalSocial = 32.01
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "33 Month",
            Id = 16,
            Communication = 25.36,
            GrossMotor = 34.8,
            FineMotor = 12.28,
            ProblemSolving = 26.92,
            PersonalSocial = 28.96
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "36 Month",
            Id = 17,
            Communication = 30.99,
            GrossMotor = 36.99,
            FineMotor = 18.07,
            ProblemSolving = 30.29,
            PersonalSocial = 35.33
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "42 Month",
            Id = 18,
            Communication = 27.06,
            GrossMotor = 36.27,
            FineMotor = 19.82,
            ProblemSolving = 28.11,
            PersonalSocial = 31.12
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "48 Month",
            Id = 19,
            Communication = 30.72,
            GrossMotor = 32.78,
            FineMotor = 15.81,
            ProblemSolving = 31.3,
            PersonalSocial = 26.6
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "54 Month",
            Id = 20,
            Communication = 31.85,
            GrossMotor = 35.18,
            FineMotor = 17.32,
            ProblemSolving = 28.12,
            PersonalSocial = 32.33
        });
        modelBuilder.Entity<ASQCutoff>().HasData(new ASQCutoff
        {
            TestType = "60 Month",
            Id = 21,
            Communication = 33.19,
            GrossMotor = 31.28,
            FineMotor = 26.54,
            ProblemSolving = 29.99,
            PersonalSocial = 39.07
        });
    }    
}
