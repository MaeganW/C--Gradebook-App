using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade); // "this" in this.grades is implicit
        }

        public double GetHighestGrade()
        {
            var HighestGrade = double.MinValue;
            foreach (var grade in this.grades)
            {
                // if (grade > HighestGrade)
                // {
                //     HighestGrade = grade;
                // }
                HighestGrade = Math.Max(grade, HighestGrade);
            }
            return HighestGrade;
        }

        public double GetLowestGrade()
        {
            var LowestGrade = double.MaxValue;
            foreach (var grade in this.grades)
            {
                LowestGrade = Math.Min(grade, LowestGrade);
            }
            return LowestGrade;
        }

        public double GetAverageGrade()
        {
            var average = 0.0;
            foreach (var grade in this.grades)
            {
                average += grade;
            }
            return average /= this.grades.Count;
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.AverageGrade = this.GetAverageGrade();
            statistics.HighestGrade = this.GetHighestGrade();
            statistics.LowestGrade = this.GetLowestGrade();

            return statistics;
        }

        public string Name; // made public for test purposes
        private List<double> grades; // this is a field on the class/type - cannot be implicitly typed
    }
}