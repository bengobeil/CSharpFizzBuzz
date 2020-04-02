using CSharpFizzBuzz.CLI.IO;
using CSharpFizzBuzz.IoC;
using CSharpFizzBuzz.IoC.Application;

namespace CSharpFizzBuzz.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationFactory = new ApplicationFactory();
            var consoleInput = new ConsoleInput();
            var consoleOutput = new ConsoleOutput();
            var application = applicationFactory.Create(consoleInput, consoleOutput);
            application.Execute();
        }
    }
}