using FizzBuzz.Filters;
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var divisibleByOrContaining3Filter = new DivisibleOrContainingFilter(3, "Fizz");
            var divisibleByOrContaining5Filter = new DivisibleOrContainingFilter(5, "Buzz");
            var fizzBuzzer = new FizzBuzzer(new List<IFilter> { divisibleByOrContaining3Filter, divisibleByOrContaining5Filter });
            var outputWriter = new ConsoleWriter();
            var app = new App(fizzBuzzer: fizzBuzzer, outputWriter: outputWriter);

            app.Run();

            Console.ReadKey();
        }
    }
}
