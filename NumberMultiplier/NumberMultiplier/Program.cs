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
            foreach (var input in inputList)
            try
            {
                var inputToNumbers = Int32.Parse(input);
                // Console.WriteLine(inputToNumbers);
                foreach (var num in inputToNumbers)
                try
                {
                    var output = num * 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();


            // string[] inputList = Console.WriteLine(inputSplit);
            Console.ReadLine();
        }
    }
}
