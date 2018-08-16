using OpenQA.Selenium;
using pom.specflow.Projects.AucklandTransport.Steps;
using pom.specflow.Projects.Planit.Steps;

namespace pom.specflow.Specflow
{
    public class DefaultContext
    {
        public IWebDriver driver;
        public string client;
        public AucklandTransport aucklandtransport;
        public Planit planit;
    }
}
