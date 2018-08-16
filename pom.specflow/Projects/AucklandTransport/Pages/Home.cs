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
            Assert.That(VerifyBrowserTitle(driver, "Auckland Transport"), Is.True);
        }
        public void ClickLogin() {
            Assert.That(WaitUntilElementExists(driver, btn_Login), Is.True);
            driver.FindElement(btn_Login).Click();
        }
    }
}