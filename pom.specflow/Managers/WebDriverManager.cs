using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pom.specflow.Managers
{
    public class WebDriverManager
    {
        private IWebDriver driver;
        public IWebDriver GetDriver()
        {
            return driver == null ? driver = Create() : driver;
        }
        public IWebDriver Create()
        {
            return driver;
        }
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
