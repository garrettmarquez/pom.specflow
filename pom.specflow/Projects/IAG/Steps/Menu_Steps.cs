using TechTalk.SpecFlow;
using pom.specflow.Specflow;
using System;
using AventStack.ExtentReports.Gherkin.Model;

namespace pom.specflow.Projects.IAG.Steps
{
    [Binding]
    public class Menu_Steps
    {
        private readonly DefaultContext defaultcontext;
        private readonly FeatureContext featurecontext;
        private readonly ScenarioContext scenariocontext;

        public Menu_Steps(DefaultContext dc, FeatureContext fc, ScenarioContext sc)
        {
            this.defaultcontext = dc;
            this.featurecontext = fc;
            this.scenariocontext = sc;
        }
        [When(@"I Navigate to Menu")]
        public void INavigateToMenu()
        {
            try
            {
                defaultcontext.iag.homepage.ClickMenu();
                defaultcontext.iag.menupage.LoadPage();
                //defaultcontext.aucklandtransport.loginpage = new Pages.Login(defaultcontext.driver);
                //defaultcontext.aucklandtransport.loginpage.LoadPage();
                //defaultcontext.aucklandtransport.loginpage.EnterUserName(email);
                //defaultcontext.aucklandtransport.loginpage.EnterPassword(password);
                Hooks.scenario.CreateNode<When>(scenariocontext.StepContext.StepInfo.Text).Pass($"Menu section is displayed.");
            }
            catch (Exception e)
            {
                Hooks.scenario.CreateNode<When>(scenariocontext.StepContext.StepInfo.Text).Fail($"Failed to display Menu section:\n{e.Message}");
            }
        }
    }
}
