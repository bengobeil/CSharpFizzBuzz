using System;
using System.Text;

namespace CSharpFizzBuzz.Gorilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 4000:");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var number))
            {
                Console.WriteLine($"{input} is not a valid integer.");
                return;
            }

            var isNumberValid = 1 <= number && number <= 4000;
            if (!isNumberValid)
            {
                Console.WriteLine($"You entered {number}. Please enter a number between 1 and 4000.");
                return;
            }
            
            var stringBuilder = new StringBuilder();
            var isReplaced = false;
            for (var i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    stringBuilder.Append("Fizz");
                    isReplaced = true;
                }

                if (i % 5 == 0)
                {
                    stringBuilder.Append("Buzz");
                    isReplaced = true;
                }

                if (!isReplaced)
                    stringBuilder.Append(i);

                isReplaced = false;
                stringBuilder.AppendLine();
            }
            
            Console.WriteLine($"Here is the output:\n{stringBuilder}");
        }
    }
}