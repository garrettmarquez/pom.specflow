using OpenQA.Selenium;

namespace pom.specflow.Projects.Sovereign.Pages
{
    public class Home : Specflow.BasePage
    {
        protected readonly IWebDriver driver;
        public Home(IWebDriver wd) => this.driver = wd;
        public void LoadPage()
        {
            driver.Navigate().GoToUrl("https://www.sovereign.co.nz/");
            VerifyBrowserTitle(driver, "AIA - NZ's Largest Life Insurer | Life & Health Insurance");
        }
    }
}
