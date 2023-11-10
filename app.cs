internal class Program
{
    private static void Main(string[] args)
    {
        //student name
        string studentName = "Mahmood Ademoye";

        //course titles
        string course1Name = "Fluid Mechanics";
        string course2Name = "Material Science";
        string course3Name = "Control Systems";
        string course4Name = "Mechanical Vibration";
        string course5Name = "Machine Design";

        //course credits
        int course1Credit = 5;
        int course2Credit = 4;
        int course3Credit = 4;
        int course4Credit = 5;
        int course5Credit = 5;

        //grades points equivalent
        int gradeA = 5;
        int gradeB = 4;

        //course grades
        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeA;
        int course5Grade = gradeA;


        //Total credit hours
        int totalCreditHours = 0;
        totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

        //Total Grade points
        int totalGradePoints = 0;
        totalGradePoints += course1Credit * course1Grade;
        totalGradePoints += course2Credit * course2Grade;
        totalGradePoints += course3Credit * course3Grade;
        totalGradePoints += course4Credit * course4Grade;
        totalGradePoints += course5Credit * course5Grade;

        //GPA
        decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
        int leadingDigit = (int) gradePointAverage;
        int firstDigit = (int) (gradePointAverage * 10) % 10;
        int secondDigit = (int) (gradePointAverage * 100) % 10;


        //OUTPUT 
        Console.WriteLine($"Student: {studentName}\n");
        //Headers
        Console.WriteLine($"Course\t\t\t\tGrade\tCredit Hours");
        //Results
        Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
        Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
        Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
        Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
        Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
        Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");
    }
}