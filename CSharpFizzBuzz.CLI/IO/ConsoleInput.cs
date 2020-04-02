using System;
using CSharpFizzBuzz.IO;

namespace CSharpFizzBuzz.CLI.IO
{
    public class ConsoleInput : IInput
    {
        public string Get()
        {
            return Console.ReadLine();
        }
    }
}