using pom.specflow.Specflow;
using TechTalk.SpecFlow;

namespace pom.specflow.Steps
{
    [Binding]
    public class SampleSteps : BaseSteps
    {
        private readonly TestContext testcontext;
        public SampleSteps(TestContext tc)
        {
            this.testcontext = tc;
        }
        [Given(@"I Launch Application")]
        public void GivenILaunchApplication()
        {
            testcontext.driver = driver;
            testcontext.homepage = new Pages.Home(testcontext.driver);
            testcontext.homepage.LoadHomePage();
        }
    }
}
