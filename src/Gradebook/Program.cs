using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 22.1F;
            float y = 33.1F;
            Console.WriteLine(x + y);

            var a = 22.1;
            var b = 33.1;
            Console.WriteLine(a + b);

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
