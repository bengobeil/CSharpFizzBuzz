using System;
using CSharpFizzBuzz.IO;

namespace CSharpFizzBuzz.CLI.IO
{
    public class ConsoleOutput : IOutput
    {
        public void Set(string output)
        {
            Console.WriteLine(output);
        }
    }
}