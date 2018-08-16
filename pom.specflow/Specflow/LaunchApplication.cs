using TechTalk.SpecFlow;

namespace pom.specflow.Specflow
{
    [Binding]
    public class LaunchApplication
    {
        private readonly DefaultContext defaultcontext;
        public LaunchApplication(DefaultContext dc)
        {
            this.defaultcontext = dc;
        }
        [Given(@"I Launch Application (.*)")]
        public void GivenILaunchApplication(string client)
        {
            defaultcontext.driver = Hooks.driver;
            switch (client.ToLower())
            {
                case "aucklandtransport":
                    defaultcontext.aucklandtransport = new Projects.AucklandTransport.Steps.AucklandTransport
                    {
                        homepage = new Projects.AucklandTransport.Pages.Home(defaultcontext.driver)
                    };
                    defaultcontext.aucklandtransport.homepage.LoadPage();
                    break;
                case "planit":
                    defaultcontext.planit = new Projects.Planit.Steps.Planit
                    {
                        homepage = new Projects.Planit.Pages.Home(defaultcontext.driver)
                    };
                    defaultcontext.planit.homepage.LoadPage();
                    break;
                default:
                    break;
            }
        }
    }
}
