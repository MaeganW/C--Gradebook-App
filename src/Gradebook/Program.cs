using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maegan's Grade Book");

            while (true)
            {
                Console.WriteLine("Enter a number grade or 'q' to quit.");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**********");
                }
            }

            // book.AddGrade(45.0);
            // book.AddGrade(90.0);
            // book.AddGrade(75.5);

            var statistics = book.GetStatistics();
            Console.WriteLine($"The statistics for the book '{book.Name}' are the following:");
            Console.WriteLine($"The highest grade is {statistics.HighestGrade}");
            Console.WriteLine($"The lowest grade is {statistics.LowestGrade}");
            Console.WriteLine($"The average grade is {statistics.AverageGrade:N1}");
            Console.WriteLine($"The average letter grade is {statistics.AverageLetterGrade}");

            // misc practice fns

            var practice = new PracticeProblems();
            // practice.run(new[] { "Maegan", "Diana" });
        }
    }
}
