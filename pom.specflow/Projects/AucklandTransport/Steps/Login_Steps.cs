using TechTalk.SpecFlow;
using pom.specflow.Specflow;
using System;
using AventStack.ExtentReports.Gherkin.Model;

namespace pom.specflow.Projects.AucklandTransport.Steps
{
    [Binding]
    public class Login_Steps
    {
        private readonly DefaultContext defaultcontext;
        private readonly FeatureContext featurecontext;
        private readonly ScenarioContext scenariocontext;

        public Login_Steps(DefaultContext dc, FeatureContext fc, ScenarioContext sc)
        {
            this.defaultcontext = dc;
            this.featurecontext = fc;
            this.scenariocontext = sc;
        }
        [When(@"I Enter Credentials (.*) (.*)")]
        public void WhenIEnterCredentials(string email, string password)
        {
            try
            {
                defaultcontext.aucklandtransport.homepage.ClickLogin();
                defaultcontext.aucklandtransport.loginpage = new Pages.Login(defaultcontext.driver);
                defaultcontext.aucklandtransport.loginpage.LoadPage();
                defaultcontext.aucklandtransport.loginpage.EnterUserName(email);
                defaultcontext.aucklandtransport.loginpage.EnterPassword(password);
            } catch (Exception e)
            {
                Hooks.scenario.CreateNode<When>(scenariocontext.StepContext.StepInfo.Text).Fail($"Failed to enter credentials due to error encountered in {e.Message}");
            }
        }
    }
}
