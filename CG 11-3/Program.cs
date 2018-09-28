using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line;
            int numberOfGrades = 0;
            StreamReader file = new StreamReader("C:\\Users\\melissa\\source\\repos\\StudentNames\\StudentNames\\TextFile1.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] lines = line.Split(" ");
                numberOfGrades = lines.Length;
                string studentName = lines[0];
                Student newStudent = new Student(studentName, numberOfGrades);
                students.Add(newStudent);
                for (int i = 1; i < lines.Length; i++)
                {
                    newStudent.AddScore(Convert.ToInt32(lines[i]));
                }

            }
            foreach (Student item in students)
            {
                Console.WriteLine(item.Name + " " + item.MinGrade() + " " + item.MaxGrade());
            }



            Console.ReadLine();
        }
    }
}
