using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by commas that you want multiplied");
            var inputs = Console.ReadLine();
            var inputList = inputs.Split(",");
            foreach (string input in inputList)
                Console.WriteLine(input);
            // string[] inputList = Console.WriteLine(inputSplit);
            Console.ReadLine();
        }
    }
}
