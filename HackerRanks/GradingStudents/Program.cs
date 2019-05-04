using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Solution
{

    /*
     * Complete the gradingStudents function below.
     */
    private static int[] gradingStudents(int[] grades)
    {
        /*
         * Write your code here.
         */
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > 40 && grades[i] % 5 != 0)
            {
                if ((grades[i] + 1) % 5 == 0)
                {
                    grades[i] = grades[i] + 1;
                }
                if ((grades[i] + 2) % 5 == 0)
                {
                    grades[i] = grades[i] + 2;
                }
            }
            else
            {
                if (grades[i] == 38 || grades[i] == 39)
                {
                    grades[i] = 40;
                }
            }
        }

        return grades;
    }

    private static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@"D:\", true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int[n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
