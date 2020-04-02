namespace CSharpFizzBuzz.Validators
{
    public class Validator : IValidator
    {
        public bool IsValid(int number)
        {
            return 1 <= number && number <= 4000;
        }
    }
}