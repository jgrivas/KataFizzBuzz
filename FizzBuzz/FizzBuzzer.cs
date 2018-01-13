using FizzBuzz.Extensions;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer
    {
        private readonly IDictionary<int, string> _resultByDivisor = new Dictionary<int, string>()
        {
            [3] = "Fizz",
            [5] = "Buzz",
        };

        public string GetNumberFizzBuzzed(int number)
        {
            var stringBuilder = new StringBuilder();

            foreach (var divisor in _resultByDivisor.Keys)
            {
                if (number.IsDivisibleBy(divisor))
                    stringBuilder.Append(_resultByDivisor[divisor]);
            }
            
            return stringBuilder.IsEmpty()
                ? number.ToString() 
                : stringBuilder.ToString();
        }
    }
}
