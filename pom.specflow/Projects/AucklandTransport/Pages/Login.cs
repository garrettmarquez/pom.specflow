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

        public Login(IWebDriver wd) => this.driver = wd;

        public void EnterUserName(string s) => EnterText(driver, txt_Username, s);
        public void EnterPassword(string s) => EnterText(driver, txt_Password, s);

        public void LoadPage()
        {
            VerifyBrowserTitle(driver, "Login to Auckland Transport");
        }

        public void ClickLogin() => ClickElement(driver, btn_Login);
    }
}