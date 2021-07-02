using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzzProcessor = new FizzBuzzProcessor();
            var Result = FizzBuzzProcessor.FizzBuzzMethod(100);
            for (int i = 0; i<Result.Length; i++)
            {
                Console.WriteLine(Result[i]);
            }
        }
    }
}
