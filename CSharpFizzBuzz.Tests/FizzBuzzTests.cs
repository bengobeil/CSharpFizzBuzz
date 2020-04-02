using NUnit.Framework;

namespace CSharpFizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzzWorks()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            Assert.That(fizzBuzz.GetFizzBuzzString(15), Is.EqualTo(
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
"));
        }
    }
}