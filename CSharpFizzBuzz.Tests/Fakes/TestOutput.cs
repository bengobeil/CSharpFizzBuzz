using System.Collections.Generic;
using CSharpFizzBuzz.IO;

namespace CSharpFizzBuzz.Tests.Fakes
{
    public class TestOutput : IOutput
    {
        public List<string> Outputs { get; } = new List<string>();

        public void Set(string output)
        {
            Outputs.Add(output);
        }
    }
}