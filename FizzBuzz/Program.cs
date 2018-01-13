using System;

namespace FizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzzer();
            var outputWriter = new ConsoleWriter();
            var app = new App(fizzBuzzer: fizzBuzzer, outputWriter: outputWriter);

            app.Run();

            Console.ReadKey();
        }
    }
}
