using OpenQA.Selenium;

namespace pom.specflow.Pages
{
    class Home : BasePage
    {
        protected readonly IWebDriver driver;
        public Home(IWebDriver wd)
        {
            this.driver = wd;
        }
        public void LoadHomePage()
        {
            driver.Navigate().GoToUrl("https://at.govt.nz/");
        }
        public void ClickLogin() {
            driver.FindElement(By.XPath("//a[contains(@href,'signin') and text()='Log in']")).Click();
        }
    }
}
