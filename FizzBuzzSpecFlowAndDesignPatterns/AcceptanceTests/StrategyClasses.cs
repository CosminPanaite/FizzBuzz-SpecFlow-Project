using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTests
{
    public interface FizzBuzzBase
    {
        public List<string> SolveFizz(int number);
    }

    public class MultipleOfThree : FizzBuzzBase
    {
        public List<string> SolveFizz(int number)
        {
            List<string> strings = new List<string>();
            string output = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0&&i%5!=0)
                {
                    output = "Fizz";

                    strings.Add(output);
                }
            }
            return strings;
        }
    }

    public class MultipleOfFive : FizzBuzzBase
    {
        public List<string> SolveFizz(int number)
        {
            List<string> strings = new List<string>();
            string output = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                if (i % 5 == 0&&i%3!=0)
                {
                    output = "Buzz";


                    strings.Add(output);
                }
            }
            return strings;
        }
    }

    public class MultipleOfThreeAnFive : FizzBuzzBase
    {
        public List<string> SolveFizz(int number)
        {
            List<string> strings = new List<string>();
            string output = string.Empty;
            for (int i = 1; i <= number; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    output = "FizzBuzz";

                    strings.Add(output);
                }
            }
            return strings;
        }
    }

    public class FizzBuzzFactory
    {
        private FizzBuzzBase fizzBuzzBase;

        
        public FizzBuzzBase Create(string multipleOf)
        {
            switch (multipleOf)
            {
                case "3":
                    fizzBuzzBase = new MultipleOfThree();
                    break;
                case "5":
                    fizzBuzzBase = new MultipleOfFive();

                    break;
                case "3 and 5":
                    fizzBuzzBase = new MultipleOfThreeAnFive();
                    break;
            }
            return fizzBuzzBase;
        }
    }
}
