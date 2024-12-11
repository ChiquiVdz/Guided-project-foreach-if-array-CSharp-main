using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

decimal[] extraPoints = new decimal[] { 3.4M, 1.6M, 2.9M, 4.1M, 6.6M };

string[] studentsName = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tExtra Points\tFinal Score\tGrade\t\t\n");

foreach (string name in studentsName)
{
    string currStudent = name;

    if (name == "Sophia")
    {
        studentScores = sophiaScores;   
    }
    else if (name == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (name == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (name == "Logan")
    {
        studentScores = loganScores;   
    }

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;
    decimal currExtraPoints = 0;

    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
    currExtraPoints = extraPoints[Array.IndexOf(studentsName, name)];
    decimal currFinalScore = currentStudentGrade + currExtraPoints;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    Console.WriteLine($"{currStudent}\t\t{currentStudentGrade}\t\t{currExtraPoints}\t\t{currFinalScore}\t\t{currentStudentLetterGrade}");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
