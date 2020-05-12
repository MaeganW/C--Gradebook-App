using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic math operations and types

            float x = 22.1F;
            float y = 33.1F;
            Console.WriteLine(x + y);

            var a = 22.1;
            var b = 33.1;
            Console.WriteLine(a + b);

            // arrays and foreach

            var arr = new double[3] { 1.12, 2.3, 4.5 }; // array of three doubles - numbers in {} are the initialized values
            var arr1 = new double[] { 1.12, 2.3, 4.5 }; // also valid
            var arr2 = new[] { 1.12, 2.3, 4.5 }; // also valid
            var result = 0.0;

            foreach (double number in arr)
            {
                result += number;
            }
            Console.WriteLine($"Result: {result}");

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
