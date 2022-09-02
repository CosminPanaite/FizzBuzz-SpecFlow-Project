using FizzBuzzProblem.Library;
using System.Collections.Immutable;

namespace FizzBuzzProblemSolution
{
    public class Program
{

        static void Main(String[] args)
    {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz.GetValue(100).ToList().ElementAt(i));
                Console.WriteLine();
                Thread.Sleep(1000);
            }   
    }
}
}