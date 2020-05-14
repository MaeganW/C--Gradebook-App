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
            if (grade <= 100 && grade > 0)
            {
                grades.Add(grade); // "this" in this.grades is implicit
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                case 'D':
                    AddGrade(60);
                    break;
                default:
                    AddGrade(50);
                    break;
            }
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

        public char GetAverageLetterGrade()
        {
            var average = this.GetAverageGrade();
            char averageLetterGrade = ' ';
            switch (average)
            {
                case var g when g >= 90:
                    averageLetterGrade = 'A';
                    break;
                case var g when g >= 80:
                    averageLetterGrade = 'B';
                    break;
                case var g when g >= 70:
                    averageLetterGrade = 'C';
                    break;
                case var g when g >= 60:
                    averageLetterGrade = 'D';
                    break;
                default:
                    averageLetterGrade = 'F';
                    break;
            }
            return averageLetterGrade;
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.AverageGrade = this.GetAverageGrade();
            statistics.HighestGrade = this.GetHighestGrade();
            statistics.LowestGrade = this.GetLowestGrade();
            statistics.AverageLetterGrade = this.GetAverageLetterGrade();

            return statistics;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid name field value");
                }
            }
        }

        // also valid getter setter
        // public string Name
        // {
        //     get;
        //     private set;
        // }

        private string name;
        private List<double> grades; // this is a field on the class/type - cannot be implicitly typed
    }
}