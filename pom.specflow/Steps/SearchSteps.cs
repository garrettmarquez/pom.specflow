using System;
using TechTalk.SpecFlow;

namespace pom.specflow.Steps
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"Planit Website is open")]
        public void GivenPlanitWebsiteIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for something")]
        public void WhenISearchForSomething()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be displayed")]
        public void ThenTheResultShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
