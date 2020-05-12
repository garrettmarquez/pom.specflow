using OpenQA.Selenium;
using pom.specflow.Projects.AucklandTransport.Steps;
using pom.specflow.Projects.IAG.Steps;
using pom.specflow.Projects.Planit.Steps;
using pom.specflow.Projects.Sovereign.Steps;

namespace pom.specflow.Specflow
{
    public class DefaultContext
    {
        public IWebDriver driver;
        public string client;

        //application pool
        public AucklandTransport aucklandtransport;
        public IAG iag;
        public Planit planit;
        public Sovereign sovereign;
    }
}
