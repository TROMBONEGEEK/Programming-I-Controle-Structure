/* ​User Input:
​Ask the student for their name.
​Prompt the user to enter scores (0–100) for 3 subjects: Math, Science, and English.
​Calculations:
​Calculate the total score and the overall percentage/average score
 ​User Input:
​Ask the student for their name.
​Prompt the user to enter scores (0–100) for 3 subjects: Math, Science, and English.
​Calculations:
​Calculate the total score and the overall percentage/average score.
​Grade Assignment (Conditional Logic):
​Use an if/else if/else structure to assign a final letter grade based on the average score:
​90–100: A
​80–89: B
​70–79: C
​60–69: D
​Below 60: F
​Output Display:
​Print a clean report summarizing:
​Student's Name
​Average Score (formatted to 2 decimal places)
​Final Letter Grade
​Status message: If the average is 70 or higher, output "Status: Passed"; otherwise, output "Status: Needs Improvement". 
=== Student Grade Calculator ===
Enter student name: Alex
Enter Math score (0-100): 88
Enter Science score (0-100): 92
Enter English score (0-100): 79
--------------------------------
ACADEMIC REPORT FOR ALEX
--------------------------------
Average Score : 86.33%
Letter Grade  : B
Status        : Passed
--------------------------------
*/

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
        int mathScore = int.Parse(Console.ReadLine());
        Console.Write("Please enter your Science score (0-100): ");
        int scienceScore = int.Parse(Console.ReadLine());
        Console.Write("Please enter your English score (0-100): ");
        int englishScore = int.Parse(Console.ReadLine());

        int totalScore = mathScore + scienceScore + englishScore;
        double averageScore = totalScore / 3.00000;

        Console.WriteLine($"{nameInput} has achieved a total score of {totalScore} and an average score of {averageScore:F2}%");
        Console.WriteLine($"Total: {totalScore}");
        Console.WriteLine($"Average: {averageScore:F2}%");

        Console.WriteLine("-" * 40);

        // This will determine the letter grade based on the average score.
        string LetterGrade;
        if(averageScore >= 90 && averageScore <= 100);
        {
            LetterGrade = "A";
        }

        elseif(averageScore >= 80 && averageScore <= 89);
        {
            LetterGrade = "B";
        }

        elseif(averageScore >= 70 && averageScore <= 79);
        {
            LetterGrade = "C";
        }

        elseif(averageScore >= 60 && averageScore <= 69);
        {
            LetterGrade = "D";
        }

        elseif(averageScore <= 59);
        {
            LetterGrade = "F";
        }

        string FinalReport;
        Console.WriteLine($"

    }
}

/*
​Student's Name
​Average Score (formatted to 2 decimal places)
​Final Letter Grade
​Status message: If the average is 70 or higher, output "Status: Passed"; otherwise, output "Status: Needs Improvement". 
=== Student Grade Calculator ===
Enter student name: Alex
Enter Math score (0-100): 88
Enter Science score (0-100): 92
Enter English score (0-100): 79
--------------------------------
ACADEMIC REPORT FOR ALEX
--------------------------------
Average Score : 86.33%
Letter Grade  : B
Status        : Passed
--------------------------------
*/