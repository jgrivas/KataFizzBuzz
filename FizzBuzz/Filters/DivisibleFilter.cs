using FizzBuzz.Extensions;

namespace FizzBuzz.Filters
{
    public class DivisibleFilter : IFilter
    {
        private readonly int _divisor;

        public DivisibleFilter(int divisor, string message)
        {
            _divisor = divisor;
            Message = message;
        }

        public string Message { get; } 

        public bool IsMet(int number)
        {
            return number.IsDivisibleBy(_divisor);
        }
    }
}
