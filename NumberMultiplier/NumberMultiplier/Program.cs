using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some numbers separated by commas");
            var input = Console.ReadLine();
            var inputs = input.Split(",");
            var loopCounter = 0;
            var total = 1;
            var output = "";
        
            Console.WriteLine("Do you want to multiply or square? If you want to multiply them, enter M. If you want to square them, press S");
            var userInput = Console.ReadLine();
            if (userInput == "M")
            {
                foreach (var num in inputs)
                {
                    var number = Int32.Parse(num);
                    total = total * number;
                    output = total.ToString();
                }
            }
            else if (userInput == "S")
            {
                foreach (var num in inputs)
                {
                    var number = Int32.Parse(num);
                    total = number * number;
                    if (loopCounter < inputs.Length)
                    {
                        output += total + ",";
                    }
                }
                output = output.Remove(output.Length - 1);
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
