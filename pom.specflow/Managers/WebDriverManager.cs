using OpenQA.Selenium;

namespace pom.specflow.Managers
{
    public class WebDriverManager
    {
        private IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver == null ? driver = Create() : driver;
        }
        public IWebDriver Create()
        {
            return driver;
        }
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
