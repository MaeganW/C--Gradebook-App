using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maegan's Grade Book");
            book.addGrade(45.0);
            book.addGrade(90.0);
            book.addGrade(75.5);

            book.showStatistics();

            // misc practice fns

            var practice = new PracticeProblems();
            // practice.run(new[] { "Maegan", "Diana" });
        }
    }
}
