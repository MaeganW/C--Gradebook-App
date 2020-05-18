using System;

namespace Gradebook
{
    public class Statistics
    {
        public double AverageGrade
        {
            get
            {
                Console.WriteLine($"Average: {Sum / Count}");
                return Sum / Count;
            }
        }
        public double HighestGrade;
        public double LowestGrade;
        public char AverageLetterGrade
        {
            get
            {
                switch (AverageGrade)
                {
                    case var g when g >= 90:
                        return 'A';
                    case var g when g >= 80:
                        return 'B';
                    case var g when g >= 70:
                        return 'C';
                    case var g when g >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int Count;

        public void Add(double grade)
        {
            HighestGrade = Math.Max(grade, HighestGrade);
            LowestGrade = Math.Min(grade, LowestGrade);
            Sum += grade;
            Count++;
        }

        public Statistics()
        {
            HighestGrade = double.MinValue;
            LowestGrade = double.MaxValue;
            Console.WriteLine($"Testing the Highest: {HighestGrade}");
            Sum = 0.0;
            Count = 0;
        }
    }
}