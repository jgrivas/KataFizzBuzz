namespace FizzBuzz
{
    public class App
    {
        private readonly IFizzBuzzer _fizzBuzzer;
        private readonly IOutputWriter _outputWriter;

        public App(IFizzBuzzer fizzBuzzer, IOutputWriter outputWriter)
        {
            _fizzBuzzer = fizzBuzzer;
            _outputWriter = outputWriter;
        }

        public void Run()
        {
            for (int number = 1; number <= 100; number++)
            {
                var numberFizzBuzzed = _fizzBuzzer.GetNumberFizzBuzzed(number);
            }
        }
    }
}
