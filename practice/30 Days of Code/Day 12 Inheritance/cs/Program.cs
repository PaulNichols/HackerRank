using System;
using System.Linq;

internal class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person()
    {
    }

    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }

    public void Print()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

internal class Student : Person
{
    private readonly int[] scores;

    public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
    {
        this.scores = scores;
    }

    internal string Calculate(int[] scores)
    {
        decimal average = (decimal)scores.Sum() / (decimal)scores.Length;
        string grade;

        if (90 <= average && average <= 100)
        {
            grade = "O";
        }
        else if (80 <= average && average < 90)
        {
            grade = "E";
        }
        else if (70 <= average && average < 80)
        {
            grade = "A";
        }
        else if (55 <= average && average < 70)
        {
            grade = "P";
        }
        else if (40 <= average && average < 55)
        {
            grade = "D";
        }
        else
        {
            grade = "T";
        }

        return grade;
    }
}

internal class Solution
{
    private static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for (int i = 0; i < numScores; i++)
        {
            scores[i] = Convert.ToInt32(inputs[i]);
        }

        Student s = new Student(firstName, lastName, id, scores);
        s.Print();
        Console.WriteLine("Grade: " + s.Calculate(scores) + "\n");
    }
}