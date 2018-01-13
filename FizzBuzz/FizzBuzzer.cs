namespace FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string GetNumberFizzBuzzed(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            return "Buzz";
        }
    }
}
