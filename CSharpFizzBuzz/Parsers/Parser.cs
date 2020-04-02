using System;

namespace CSharpFizzBuzz.Parsers
{
    public class Parser : IParser
    {
        public bool TryParse(string input, out int value)
        {
            return int.TryParse(input, out value);
        }
    }
}