using System;

namespace FizzBuzz.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }

        public static bool ContainsDigit(this int number, int digit)
        {
            if (digit < 0 || digit > 9)
                throw new ArgumentOutOfRangeException(nameof(digit), digit, "It should be a value between 0 and 9.");

            return number.ToString().Contains(digit.ToString());
        }
    }
}
