using FizzBuzzProblem.Library;
using TechTalk.SpecFlow;

namespace AcceptanceTests
{
    [Binding]
    public class FizzBuzzStepDefinitions
    {
        
        private readonly FizzBuzzContext fizzBuzzContext;
        private readonly FizzBuzzFactory fizzBuzzFactory;
        int number=0;
        public FizzBuzzStepDefinitions(FizzBuzzContext fizzBuzzContext, FizzBuzzFactory fizzBuzzFactory)
        {
            this.fizzBuzzContext = fizzBuzzContext;
            this.fizzBuzzFactory = fizzBuzzFactory;
        }

        [Given(@"a user has a range of (.*) numers")]
        public void GivenAUserHasARangeOfNumers(int p0)
        {
            number = p0;
        }

        [When(@"the user tries to print the numbers multiple of (.*) in that range")]
        public void WhenTheUserTriesToPrintTheNumbersMultipleOfInThatRange(string p0)
        {

            var fizzBuzzSolver = fizzBuzzFactory.Create(p0);
            fizzBuzzContext.MultipleOfNumber = fizzBuzzSolver.SolveFizz(number);
            
        }

        
    }
}
