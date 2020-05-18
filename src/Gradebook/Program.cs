using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new DiskBook("Maegan's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            // var statistics = book.GetStatistics();
            Console.WriteLine($"The statistics for the book '{book.Name}' are the following:");
            // Console.WriteLine($"In the {InMemoryBook.CATEGORY} category...");
            // Console.WriteLine($"The highest grade is {statistics.HighestGrade}");
            // Console.WriteLine($"The lowest grade is {statistics.LowestGrade}");
            // Console.WriteLine($"The average grade is {statistics.AverageGrade:N1}");
            // Console.WriteLine($"The average letter grade is {statistics.AverageLetterGrade}");

            // misc practice fns

            var practice = new PracticeProblems();
            // practice.run(new[] { "Maegan", "Diana" });
        }

        private static void EnterGrades(IBook book)
        {
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
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
