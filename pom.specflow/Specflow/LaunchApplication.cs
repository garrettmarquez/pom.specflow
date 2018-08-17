using AventStack.ExtentReports.Gherkin.Model;
using System;
using TechTalk.SpecFlow;

namespace pom.specflow.Specflow
{
    [Binding]
    public class LaunchApplication
    {
        //context injections
        private readonly DefaultContext defaultcontext;
        private readonly FeatureContext featurecontext;
        private readonly ScenarioContext scenariocontext;

        public LaunchApplication(DefaultContext dc, FeatureContext fc, ScenarioContext sc)
        {
            this.defaultcontext = dc;
            this.featurecontext = fc;
            this.scenariocontext = sc;
        }

        [Given(@"I Launch Application (.*)")]
        public void GivenILaunchApplication(string client)
        {
            defaultcontext.driver = Hooks.driver;
            string reportclient = "";
            Hooks.feature = Hooks.extent.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
            Hooks.scenario = Hooks.feature.CreateNode<Scenario>(scenariocontext.ScenarioInfo.Title);
            try {
                switch (client.ToLower())
                {
                    case "aucklandtransport":
                        defaultcontext.aucklandtransport = new Projects.AucklandTransport.Steps.AucklandTransport
                        {
                            homepage = new Projects.AucklandTransport.Pages.Home(defaultcontext.driver)
                        };
                        defaultcontext.aucklandtransport.homepage.LoadPage();
                        reportclient = "Auckland Transport";
                        break;
                    case "planit":
                        defaultcontext.planit = new Projects.Planit.Steps.Planit
                        {
                            homepage = new Projects.Planit.Pages.Home(defaultcontext.driver)
                        };
                        defaultcontext.planit.homepage.LoadPage();
                        reportclient = "Planit";
                        break;
                    default:
                        throw new Customization.Exceptions.CustomException($"\"{client}\" is not yet supported");
                }
                Hooks.scenario.CreateNode<Given>(scenariocontext.StepContext.StepInfo.Text).Pass($"Successfully launched {reportclient} website.");
            } catch (ArgumentOutOfRangeException e) {
                Hooks.scenario.CreateNode<Given>(scenariocontext.StepContext.StepInfo.Text).Fail($"Failed to launch {client}. {e.Message}");
            } catch (Exception e)
            {
                Hooks.scenario.CreateNode<Given>(scenariocontext.StepContext.StepInfo.Text).Fail($"Failed to launch {client}. {e.Message}");
            }
        }
    }
}
