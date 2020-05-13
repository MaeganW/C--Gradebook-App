using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maegan's Grade Book");
            book.AddGrade(45.0);
            book.AddGrade(90.0);
            book.AddGrade(75.5);

            var statistics = book.GetStatistics();
            Console.WriteLine($"The highest grade is {statistics.highestGrade}");
            Console.WriteLine($"The lowest grade is {statistics.lowestGrade}");
            Console.WriteLine($"The average grade is {statistics.averageGrade:N1}");

            // misc practice fns

            var practice = new PracticeProblems();
            // practice.run(new[] { "Maegan", "Diana" });
        }
    }
}
