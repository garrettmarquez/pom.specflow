using NUnit.Framework;
using OpenQA.Selenium;

namespace pom.specflow.Projects.IAG.Pages
{
    public class Menu : Specflow.BasePage
    {
        protected readonly IWebDriver driver;

        private By btn_Home = By.XPath("//a[contains(@href,'iag.co.nz') and text()='Home']");

        public Menu(IWebDriver wd) => this.driver = wd;

        public void LoadPage()
        {
            WaitUntilElementExists(driver, btn_Home);
        }
    }
}
