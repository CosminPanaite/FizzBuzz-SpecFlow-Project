namespace FizzBuzzProblem
{
    public class Program
    {
        static void Main(String[] args)
        {
            for(int i = 0; i <=100; i++)
            {
                Console.WriteLine(FizzBuzzProblem.Library.FizzBuzz.GetValue(i));
                Thread.Sleep(1000);
            }
        }
    }
}