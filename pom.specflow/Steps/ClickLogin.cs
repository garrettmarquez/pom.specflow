using pom.specflow.Specflow;
using TechTalk.SpecFlow;

namespace pom.specflow.Steps
{
    [Binding]
    public class ClickLogin
    {
        private readonly TestContext testcontext;
        public ClickLogin(TestContext tc)
        {
            this.testcontext = tc;
        }
        [When(@"I Click Login")]
        public void WhenIClickLogin()
        {
            testcontext.homepage.ClickLogin();
        }
    }
}
