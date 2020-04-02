using System;

namespace CSharpFizzBuzz.Workflows.Exceptions
{
    public class NotANumberException : Exception
    {
        public string Input { get; }

        public NotANumberException(string input) : base("Please enter a valid integer between 1 and 4000")
        {
            Input = input;
        }
    }
}