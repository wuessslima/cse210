using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignmentTest = new Assignment("Wesley", "Multiplication");
        Console.WriteLine(assignmentTest.GetSummary());

        MathAssignment mathAssignmentTest = new MathAssignment("Wesley", "Multiplication", "7.3", "8-19");
        Console.WriteLine(mathAssignmentTest.GetHomeworkList());

    }
}