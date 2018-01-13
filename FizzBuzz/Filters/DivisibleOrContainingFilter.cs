using FizzBuzz.Extensions;

namespace FizzBuzz.Filters
{
    public class DivisibleOrContainingFilter : IFilter
    {
        private readonly int _divisor;

        public DivisibleOrContainingFilter(int divisor, string message)
        {
            _divisor = divisor;
            Message = message;
        }

        public string Message { get; }

        public bool IsMet(int number)
        {
            return number.IsDivisibleBy(_divisor) || number.ContainsDigit(_divisor);
        }
    }
}
