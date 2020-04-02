using System.Linq;
using CSharpFizzBuzz.IoC.Application;
using CSharpFizzBuzz.Tests.Fakes;
using NUnit.Framework;

namespace CSharpFizzBuzz.Tests.Component
{
    [TestFixture]
    public class ComponentTests
    {
        [Test]
        public void WhenInputIsValidTheOutputContainsValidResult()
        {
            var applicationFactory = new ApplicationFactory();
            var input = new TestInput("15");
            var output = new TestOutput();
            
            applicationFactory
                .Create(input, output)
                .Execute();

            var actual = output.Outputs.Last();
            const string expected = 
@"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("Tomato", "Tomato is not a valid integer.")]
        [TestCase("0", "You entered 0. Please enter a number between 1 and 4000.")]
        public void WhenBadInputIsEnteredThenErrorMessageIsShown(string inputString, string expected)
        {
            var applicationFactory = new ApplicationFactory();
            var input = new TestInput(inputString);
            var output = new TestOutput();
            
            applicationFactory
                .Create(input, output)
                .Execute();

            var actual = output.Outputs.Last();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}