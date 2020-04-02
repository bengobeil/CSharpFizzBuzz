namespace CSharpFizzBuzz.Parsers
{
    public interface IParser
    {
        bool TryParse(string input, out int value);
    }
}