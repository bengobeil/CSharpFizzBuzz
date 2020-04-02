using CSharpFizzBuzz.Parsers;
using CSharpFizzBuzz.Validators;

namespace CSharpFizzBuzz.IoC.Domain
{
    public class DomainFactory
    {
        internal CSharpFizzBuzz.Domain Create()
        {
            var parser = new Parser();
            var validator = new Validator();
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            return new CSharpFizzBuzz.Domain(parser, validator, fizzBuzz);
        }
    }
}