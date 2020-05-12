
using OpenQA.Selenium;

namespace pom.specflow.Projects.IAG.Pages
{
    public class Home : Specflow.BasePage
    {
        protected readonly IWebDriver driver;

        private By btn_Menu = By.XPath("//span[@class='label' and text()='Menu']");

        public Home(IWebDriver wd) => this.driver = wd;

        public void LoadPage()
        {
            driver.Navigate().GoToUrl("https://www.iag.co.nz/");
            VerifyBrowserTitle(driver, "Home");
        }

        public void ClickMenu() => ClickElement(driver, btn_Menu);
    }
}
