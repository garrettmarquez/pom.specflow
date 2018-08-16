using TechTalk.SpecFlow;
using pom.specflow.Specflow;

namespace pom.specflow.Projects.AucklandTransport.Steps
{
    [Binding]
    public class Login_Steps
    {
        private readonly DefaultContext defaultcontext;
        public Login_Steps(DefaultContext dc)
        {
            this.defaultcontext = dc;
        }
        [When(@"I Enter Credentials (.*) (.*)")]
        public void WhenIEnterCredentials(string email, string password)
        {
            defaultcontext.aucklandtransport.homepage.ClickLogin();
            defaultcontext.aucklandtransport.loginpage = new Pages.Login(defaultcontext.driver);
            defaultcontext.aucklandtransport.loginpage.LoadPage();
            defaultcontext.aucklandtransport.loginpage.EnterUserName(email);
            defaultcontext.aucklandtransport.loginpage.EnterPassword(password);
        }
    }
}
