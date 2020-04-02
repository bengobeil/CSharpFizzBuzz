using CSharpFizzBuzz.Validators;
using NUnit.Framework;

namespace CSharpFizzBuzz.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        [TestCase(1)]
        [TestCase(4000)]
        [TestCase(15)]
        public void ValidNumbersPass(int number)
        {
            var validator = new Validator();
            Assert.That(validator.IsValid(number));
        }
        
        [TestCase(-1)]
        [TestCase(40001)]
        public void InvalidNumbersFail(int number)
        {
            var validator = new Validator();
            Assert.That(validator.IsValid(number), Is.False);
        }
    }
}