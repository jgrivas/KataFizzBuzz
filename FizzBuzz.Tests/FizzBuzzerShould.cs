using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzerShould
    {
        [Fact]
        public void ReturnFizz_WhenTheNumberIs3()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(3);

            result.Should().Be("Fizz");
        }
    }
}
