using CSharpFizzBuzz.Parsers;
using NUnit.Framework;

namespace CSharpFizzBuzz.Tests
{
    [TestFixture]
    public class ParserTests
    {
        [TestCase("asdfa")]
        [TestCase(null)]
        [TestCase("1.4")]
        public void BadInputThrowsNotANumberException(string input)
        {
            var parser = new Parser();
            Assert.False(parser.TryParse(input, out _));
        }
        
        [TestCase("12", 12)]
        [TestCase("-25", -25)]
        public void GoodInputReturnsTrue(string input, int expected)
        {
            var parser = new Parser();
            Assert.That(parser.TryParse(input, out var actual));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}