using System;
using System.Collections.Generic;

namespace Gradebook
{
    class PracticeProblems
    {
        public void run(string[] args)
        {
            // basic math operations and types

            float x = 22.1F;
            float y = 33.1F;
            Console.WriteLine(x + y);

            var a = 22.1;
            var b = 33.1;
            Console.WriteLine(a + b);

            // arrays and foreach - arrays have a fixed size

            var arr = new double[3] { 1.12, 2.3, 4.5 }; // array of three doubles - numbers in {} are the initialized values
            arr[0] = 2.2;
            var arr1 = new double[] { 1.12, 2.3, 4.5 }; // also valid
            var arr2 = new[] { 1.12, 2.3, 4.5 }; // also valid

            var result = 0.0;
            foreach (double number in arr)
            {
                result += number;
            }
            Console.WriteLine($"Result: {result}");

            // Lists and Basic Math - lists are similar to arrays but dynamically sized

            List<double> grades = new List<double>();
            grades.Add(98.5);

            var grades2 = new List<double>() { 75.0, 88.5 };
            grades2.Add(90.5);

            var length = grades2.Count;
            Console.WriteLine($"Length of Grades2 List: {length}");

            var result2 = 0.0;
            foreach (var number in grades2)
            {
                result2 += number;
            }
            Console.WriteLine($"Result2: {result2}");

            var average = result2 / length;
            Console.WriteLine($"Average of grades2: {average}");

            result2 /= grades2.Count; // another syntax to use division - similar to +=
            Console.WriteLine($"Average of grades2: {result2}");
            Console.WriteLine($"Average of grades2: {result2:N1}"); // using formatting string for the double

            // if/else condition and string interpolation

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}