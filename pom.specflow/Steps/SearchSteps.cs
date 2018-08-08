using NUnit.Framework;
using pom.specflow.Specflow;
using TechTalk.SpecFlow;

namespace pom.specflow.Steps
{
    [Binding]
    public class SearchSteps : BaseSteps
    {
        //private TestCase tc;
        [Given(@"Planit Website is open")]
        public void GivenPlanitWebsiteIsOpen()
        {
            TestContext.Out.WriteLine("GIVEN TEST");
        }
        
        [When(@"I search for something")]
        public void WhenISearchForSomething()
        {
            TestContext.Out.WriteLine("WHEN TEST");
        }
        
        [Then(@"the result should be displayed")]
        public void ThenTheResultShouldBeDisplayed()
        {
            TestContext.Out.WriteLine("THEN TEST");
        }

    }
}
