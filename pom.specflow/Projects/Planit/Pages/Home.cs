using NUnit.Framework;
using OpenQA.Selenium;

namespace pom.specflow.Projects.Planit.Pages
{
    public class Home : Specflow.BasePage
    {
        protected readonly IWebDriver driver;
        public Home(IWebDriver wd) => this.driver = wd;
        public void LoadPage()
        {
            driver.Navigate().GoToUrl("https://www.planittesting.com/");
            VerifyBrowserTitle(driver, "Planit - Software Testing");
        }
    }
}