using CSharpFizzBuzz.FizzBuzz;
using CSharpFizzBuzz.Parsers;
using CSharpFizzBuzz.Validators;
using CSharpFizzBuzz.Workflows.Exceptions;

namespace CSharpFizzBuzz
{
    public class Domain
    {
        private readonly IParser _parser;
        private readonly IValidator _validator;
        private readonly IFizzBuzz _fizzBuzz;

        public Domain(IParser parser, IValidator validator, IFizzBuzz fizzBuzz)
        {
            _parser = parser;
            _validator = validator;
            _fizzBuzz = fizzBuzz;
        }

        public string Execute(string input)
        {
            if(!_parser.TryParse(input, out var parsedInt))
                throw new NotANumberException(input);

            if (!_validator.IsValid(parsedInt))
                throw new InvalidNumberException(parsedInt);

            return _fizzBuzz.GetFizzBuzzString(parsedInt);
        }
    }
}