using System.Text;

namespace CSharpFizzBuzz.FizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        public string GetFizzBuzzString(int number)
        {
            var stringBuilder = new StringBuilder();
            var isReplaced = false;
            for (var i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    stringBuilder.Append("Fizz");
                    isReplaced = true;
                }

                if (i % 5 == 0)
                {
                    stringBuilder.Append("Buzz");
                    isReplaced = true;
                }

                if (!isReplaced)
                    stringBuilder.Append(i);

                isReplaced = false;
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}