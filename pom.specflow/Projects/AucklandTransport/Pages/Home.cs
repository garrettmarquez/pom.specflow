using NUnit.Framework;
using OpenQA.Selenium;

namespace pom.specflow.Projects.AucklandTransport.Pages
{
    public class Home : Specflow.BasePage
    {
        protected readonly IWebDriver driver;
        private By btn_Login = By.XPath("//a[contains(@href,'signin') and text()='Log in']");
        public Home(IWebDriver wd)
        {
            this.driver = wd;
        }
        public void LoadPage()
        {
            driver.Navigate().GoToUrl("https://at.govt.nz/");
            VerifyBrowserTitle(driver, "Auckland Transport");
        }
        public void ClickLogin() {
            ClickElement(driver, btn_Login);
        }
    }
}