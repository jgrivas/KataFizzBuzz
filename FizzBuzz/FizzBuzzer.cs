using FizzBuzz.Extensions;
using FizzBuzz.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer
    {
        private readonly IEnumerable<IFilter> _filters;

        public FizzBuzzer(IEnumerable<IFilter> filters)
        {
            _filters = filters ?? Enumerable.Empty<IFilter>();
        }
        
        public string GetNumberFizzBuzzed(int number)
        {
            var stringBuilder = new StringBuilder();

            foreach (var filter in _filters)
            {
                if (filter.IsMet(number))
                    stringBuilder.Append(filter.Message);
            }
            
            return stringBuilder.IsEmpty()
                ? number.ToString() 
                : stringBuilder.ToString();
        }
    }
}
