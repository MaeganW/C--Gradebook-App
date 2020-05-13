using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.addGrade(45.0);

            // misc practice fns

            var practice = new PracticeProblems();
            practice.run(new[] { "Maegan", "Diana" });
        }
    }
}
