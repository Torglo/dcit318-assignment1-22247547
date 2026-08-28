using System;

Console.Write("Enter your grade (0-100): ");
string? input = Console.ReadLine();

if (!int.TryParse(input, out int grade))
{
    Console.WriteLine("Invalid input. Please enter a whole number between 0 and 100.");
}
else if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
}
else
{
    string letterGrade;

    if (grade >= 90)
    {
        letterGrade = "A";
    }
    else if (grade >= 80)
    {
        letterGrade = "B";
    }
    else if (grade >= 70)
    {
        letterGrade = "C";
    }
    else if (grade >= 60)
    {
        letterGrade = "D";
    }
    else
    {
        letterGrade = "F";
    }

    Console.WriteLine($"Grade: {letterGrade}");
}
