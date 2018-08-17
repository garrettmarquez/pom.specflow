using NUnit.Framework;
using OpenQA.Selenium;

namespace pom.specflow.Projects.AucklandTransport.Pages
{
    public class Login : Specflow.BasePage
    {
        protected readonly IWebDriver driver;
        private By btn_Login = By.Id("submitButton");
        private By txt_Username = By.Name("UserName");
        private By txt_Password = By.Name("Password");
        public Login(IWebDriver wd)
        {
            this.driver = wd;
        }
        public void EnterUserName(string s)
        {
            Assert.That(WaitUntilElementExists(driver, txt_Username), Is.True);
            driver.FindElement(txt_Username).Click();
            driver.FindElement(txt_Username).SendKeys(s);
        }
        public void LoadPage()
        {
            Assert.That(VerifyBrowserTitle(driver, "Login to Auckland Transport"), Is.True);
        }
        public void EnterPassword(string s)
        {
            Assert.That(WaitUntilElementExists(driver, txt_Password), Is.True);
            driver.FindElement(txt_Password).Click();
            driver.FindElement(txt_Password).SendKeys(s);
        }
        public void ClickLogin() {
            ClickElement(driver, btn_Login);
        }
    }
}