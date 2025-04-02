using System;
using System.Linq;

namespace STUDENT_GRADES_matrix
{
    public static class Program
    {
        public static void Main()
        {
            int[,] grades = { { 87, 90, 85 }, { 88, 86, 84 }, { 91, 89, 93 }, { 80, 85, 84 }, { 88, 87, 90 } };
            int students = grades.GetLength(0), subjects = grades.GetLength(1);


            Console.WriteLine("=====================================");
            Console.WriteLine("           STUDENT GRADES           ");
            Console.WriteLine("=====================================\n");

            Console.WriteLine("Grades Matrix:");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < students; i++, Console.WriteLine())
                for (int j = 0; j < subjects; j++)
                    Console.Write(grades[i, j] + "\t");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Average Grades per Student:");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < students; i++)
                Console.WriteLine($" Student {i + 1}: {Avg(grades, i, subjects)}");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine("Highest Grades per Subject:");
            Console.WriteLine("-------------------------------------");
            for (int j = 0; j < subjects; j++)
                Console.WriteLine($" Subject {j + 1}: {Max(grades, students, j)}");
            Console.WriteLine("-------------------------------------\n");
        }

        static int Avg(int[,] g, int s, int sub) => (g[s, 0] + g[s, 1] + g[s, 2]) / sub;
        static int Max(int[,] g, int stu, int sub) { int h = g[0, sub]; for (int i = 1; i < stu; i++) h = Math.Max(h, g[i, sub]); return h; }
    }
}