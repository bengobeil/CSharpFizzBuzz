using System;

namespace CSharpFizzBuzz.Workflows.Exceptions
{
    public class InvalidNumberException : Exception
    {
        public int ParsedInt { get; }

        public InvalidNumberException(int parsedInt)
        {
            ParsedInt = parsedInt;
        }
    }
}