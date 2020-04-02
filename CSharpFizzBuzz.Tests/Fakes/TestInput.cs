using CSharpFizzBuzz.IO;

namespace CSharpFizzBuzz.Tests.Fakes
{
    public class TestInput : IInput
    {
        private readonly string _input;

        public TestInput(string input)
        {
            _input = input;
        }

        public string Get()
        {
            return _input;
        }
    }
}