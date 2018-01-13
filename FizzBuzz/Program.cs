using FizzBuzz.Filters;
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var divisibleBy3Filter = new DivisibleFilter(3, "Fizz");
            var divisibleBy5Filter = new DivisibleFilter(5, "Buzz");
            var fizzBuzzer = new FizzBuzzer(new List<IFilter> { divisibleBy3Filter, divisibleBy5Filter });
            var outputWriter = new ConsoleWriter();
            var app = new App(fizzBuzzer: fizzBuzzer, outputWriter: outputWriter);

            app.Run();

            Console.ReadKey();
        }
    }
}
