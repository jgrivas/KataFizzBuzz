using FizzBuzz.Filters;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzerShould
    {
        [Fact]
        public void ReturnFizz_WhenTheNumberIs3()
        {
            var fizzBuzzer = GetFizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(3);

            result.Should().Be("Fizz");
        }
        
        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(33)]
        public void ReturnFizz_WhenTheNumberIsDivisibleBy3(int inputNumber)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            result.Should().Be("Fizz");
        }

        [Fact]
        public void ReturnBuzz_WhenTheNumberIs5()
        {
            var fizzBuzzer = GetFizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(5);

            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void ReturnBuzz_WhenTheNumberIsDivisibleBy5(int inputNumber)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(90)]
        public void ReturnFizzBuzz_WhenTheNumberIsDivisibleBy3AndBy5(int inputNumber)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var result = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            result.Should().Be("FizzBuzz");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(26, "26")]
        public void ReturnTheNumber_WhenTheNumberIsNotDivisibleNeitherBy3NorBy5(int inputNumber, string expectedResult)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var actualResult = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            actualResult.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(23)]
        [InlineData(31)]
        public void ReturnFizz_WhenTheNumberContains3(int inputNumber)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var actualResult = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            actualResult.Should().Be("Fizz");
        }

        [Theory]
        [InlineData(52)]
        [InlineData(56)]
        [InlineData(58)]
        [InlineData(59)]
        public void ReturnBuzz_WhenTheNumberContains5(int inputNumber)
        {
            var fizzBuzzer = GetFizzBuzzer();

            var actualResult = fizzBuzzer.GetNumberFizzBuzzed(inputNumber);

            actualResult.Should().Be("Buzz");
        }

        #region Factories
        public IFizzBuzzer GetFizzBuzzer()
        {
            var divisibleByOrContaining3Filter = new DivisibleOrContainingFilter(3, "Fizz");
            var divisibleByOrContaining5Filter = new DivisibleOrContainingFilter(5, "Buzz");
            return new FizzBuzzer(new List<IFilter> { divisibleByOrContaining3Filter, divisibleByOrContaining5Filter });
        }
        #endregion
    }
}
