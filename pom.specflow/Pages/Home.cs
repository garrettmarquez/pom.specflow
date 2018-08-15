using NUnit.Framework;
using OpenQA.Selenium;

namespace pom.specflow.Pages
{
    public class Home : BasePage
    {
        protected readonly IWebDriver driver;
        private By buttonLogin = By.XPath("//a[contains(@href,'signin') and text()='Log in']");
        public Home(IWebDriver wd)
        {
            this.driver = wd;
        }
        public void LoadHomePage()
        {
            driver.Navigate().GoToUrl("https://at.govt.nz/");
            Assert.That(VerifyBrowserTitle(driver, "Auckland Transport"), Is.True);
        }
        public void ClickLogin() {
            Assert.That(WaitUntilElementExists(driver, buttonLogin), Is.True);
            driver.FindElement(buttonLogin).Click();
        }
    }
}