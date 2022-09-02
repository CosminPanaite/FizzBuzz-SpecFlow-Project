using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AcceptanceTests
{
    [Binding]
    public class FizzBuzzResultsSteps
    {
        private FizzBuzzContext fizzBuzzContext;

        public FizzBuzzResultsSteps(FizzBuzzContext fizzBuzzContext)
        {
            this.fizzBuzzContext = fizzBuzzContext;

        }
        [Then(@"the result is (.*)")]
        public void ThenTheResultItIsCorrect(int p0)
        {
            Assert.AreEqual(fizzBuzzContext.MultipleOfNumber.Count, p0);
        }

    }
}
