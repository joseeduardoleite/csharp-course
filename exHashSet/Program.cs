using System;
using System.Collections.Generic;

namespace exHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int nmrStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < nmrStudent; i++)
            {
                int codetudent = int.Parse(Console.ReadLine());
                courseA.Add(codetudent);
            }

            Console.Write("How many students for course B? ");
            nmrStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < nmrStudent; i++)
            {
                int codeStudent = int.Parse(Console.ReadLine());
                courseB.Add(codeStudent);
            }

            Console.Write("How many students for course C? ");
            nmrStudent = int.Parse(Console.ReadLine());

            for (int i = 0; i < nmrStudent; i++)
            {
                int codeStudent = int.Parse(Console.ReadLine());
                courseC.Add(codeStudent);
            }

            HashSet<int> allStudent = new HashSet<int>();
            allStudent.UnionWith(courseB);
            allStudent.UnionWith(courseC);
            Console.WriteLine("Total students: " + allStudent.Count);
        }
    }
}
