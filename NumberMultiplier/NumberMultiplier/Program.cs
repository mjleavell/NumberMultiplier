using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas that you want multiplied");
            var input = Console.ReadLine();
            var inputs = input.Split(",");
            var total = 1;

            foreach (var num in inputs)
            {
                var number = Int32.Parse(num);
                total = total * number;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
