
using System;

internal class Grades
{
 
    public static void MeanStudentGrade(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int gradesSum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                gradesSum += matrix[i,j];
            }

            Console.WriteLine("Mean grade of student " + i + " is: " + (gradesSum/matrix.GetLength(1)));

        }
    }

    private static void Main(string[] args)
    {
        /*
         * the application gets matrix with students grades as following:
         * 
         * student1 55 77 99
         * student2 66 34 67
         * student3 90 23 87
         * 
         * each line stands for a student, each column stands for a course
         * for example, the first line is 55 77 99 and these are grades of a student in 3 different courses
         * 
         * the application calculates a mean grade for each student and prints this grade
         * example: mean grade of student1 is: (55+77+99)/3 = 77
         */

        int[,] matrix = { { 90, 56 }, { 76, 77 }, { 65, 87 } };

        MeanStudentGrade(matrix);
    }
}