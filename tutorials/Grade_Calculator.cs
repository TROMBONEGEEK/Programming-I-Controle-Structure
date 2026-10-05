using System;
using System.Reflection.Metadata;

class Grades
{
    static void Main()
    {
        // Input your name and the score acheived for each class.
        Console.Write("Please enter your name: ");
        string nameInput = Console.ReadLine();
        Console.Write("Please enter your Math score (0-100): ");
        double mathScore = double.Parse(Console.ReadLine());
        Console.Write("Please enter your Science score (0-100): ");
        double scienceScore = double.Parse(Console.ReadLine());
        Console.Write("Please enter your English score (0-100): ");
        double englishScore = double.Parse(Console.ReadLine());

        double totalScore = mathScore + scienceScore + englishScore;
        double averageScore = totalScore / 3.00000;

        Console.WriteLine($"Total: {totalScore}");
        Console.WriteLine($"Average: {averageScore:F2}%");

        string line = new string('-', 39);
        Console.WriteLine(line);

        // This will determine the letter grade based on the average score (0-100).
        string LetterGrade;
        string statusGrade;
        if(averageScore >= 90 && averageScore <= 100)
        {
            LetterGrade = "A";
        }

        else if(averageScore >= 80 && averageScore <= 89)
        {
            LetterGrade = "B";
        }

        else if(averageScore >= 70 && averageScore <= 79)
        {
            LetterGrade = "C";
        }

        else if(averageScore >= 60 && averageScore <= 69)
        {
            LetterGrade = "D";
        }

        else
        {
            LetterGrade = "F";
        }

        // This will tell you if you "passed" or "failed" based on the letter grade
        if(averageScore >= 70)
        {
            statusGrade = "Pass";
        }

        else
        {
            statusGrade = "Fail";
        }

        // This prints the final grade report
        Console.Write($"ACADEMIC REPORT FOR ");
        Console.WriteLine(nameInput.ToUpper());

        Console.WriteLine(line);

        Console.WriteLine($"Average Score: {averageScore:F2}%");
        Console.WriteLine($"Letter Grade: {LetterGrade}");
        Console.WriteLine($"Status: {statusGrade}");

        Console.WriteLine(line);
    }
}