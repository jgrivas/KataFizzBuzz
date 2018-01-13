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
        
        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(333)]
        public void ReturnFizz_WhenTheNumberIsDivisibleBy3(int inputNumber)
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void ReturnBuzz_WhenTheNumberIs5()
        {
            var fizzBuzzer = new FizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(5);

            result.Should().Be("Buzz");
        }
    }
}
