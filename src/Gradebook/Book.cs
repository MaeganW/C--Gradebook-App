using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name; // normally "this" is implicit, but because "name" is a param, we need to be explicit
        }
        public void addGrade(double grade)
        {
            grades.Add(grade); // "this" in this.grades is implicit
        }

        public double getHighestGrade()
        {
            var highestGrade = double.MinValue;
            foreach (var grade in this.grades)
            {
                // if (grade > highestGrade)
                // {
                //     highestGrade = grade;
                // }
                highestGrade = Math.Max(grade, highestGrade);
            }
            return highestGrade;
        }

        public double getLowestGrade()
        {
            var lowestGrade = double.MaxValue;
            foreach (var grade in this.grades)
            {
                lowestGrade = Math.Min(grade, lowestGrade);
            }
            return lowestGrade;
        }

        public double getAverageGrade()
        {
            var average = 0.0;
            foreach (var grade in this.grades)
            {
                average += grade;
            }
            return average /= this.grades.Count;
        }

        public void showStatistics()
        {
            Console.WriteLine($"The highest grade is {this.getHighestGrade()}");
            Console.WriteLine($"The lowest grade is {this.getLowestGrade()}");
            Console.WriteLine($"The average grade is {this.getAverageGrade():N1}");
        }

        private List<double> grades; // this is a field on the class/type - cannot be implicitly typed
        private string name; // make fields private for better encapsulation
    }
}