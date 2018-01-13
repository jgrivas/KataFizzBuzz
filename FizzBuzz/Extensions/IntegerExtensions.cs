namespace FizzBuzz.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor)
        {
            return dividend % divisor == 0;
        }
    }
}
