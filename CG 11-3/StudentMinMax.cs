using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace StudentNames
{
    public class Student
    {
        public List<int> scores = new List<int>();
        public string Name { get; set; }
        public int Grades { get; set; }
        public object Add { get; internal set; }

        public Student(string name, int grades)
        {
            Name = name;
            Grades = grades;
        }
        public void AddScore(int score)
        {
            scores.Add(score);
        }
        public int MinGrade()
        {
            return scores.Min();
        }
        public int MaxGrade()
        {
            return scores.Max();
        }

    }
}