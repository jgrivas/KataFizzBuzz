using FizzBuzz.Extensions;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string GetNumberFizzBuzzed(int number)
        {
            var stringBuilder = new StringBuilder();

            if (number.IsDivisibleBy(3))
                stringBuilder.Append("Fizz");

            if (number.IsDivisibleBy(5))
                stringBuilder.Append("Buzz");
            
            return stringBuilder.IsEmpty()
                ? number.ToString() 
                : stringBuilder.ToString();
        }
    }
}
