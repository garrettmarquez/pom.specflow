using OpenQA.Selenium;

namespace pom.specflow.Specflow
{
    public class DriverManager
    {
        private readonly IWebDriver driver;
        public DriverManager(IWebDriver d)
        {
            this.driver = d;
        }
        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
