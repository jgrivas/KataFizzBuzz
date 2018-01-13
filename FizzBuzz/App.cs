namespace FizzBuzz
{
    public class App
    {
        private const int StartNumber = 1;
        private const int EndNumber = 100;

        private readonly IFizzBuzzer _fizzBuzzer;
        private readonly IOutputWriter _outputWriter;

        public App(IFizzBuzzer fizzBuzzer, IOutputWriter outputWriter)
        {
            _fizzBuzzer = fizzBuzzer;
            _outputWriter = outputWriter;
        }

        public void Run()
        {
            for (int number = StartNumber; number <= EndNumber; number++)
                ProcessNumber(number);
        }

        private void ProcessNumber(int number)
        {
            var numberFizzBuzzed = _fizzBuzzer.GetNumberFizzBuzzed(number);
            _outputWriter.WriteLine(numberFizzBuzzed);
        }
    }
}
