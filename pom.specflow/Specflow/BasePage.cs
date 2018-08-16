using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace pom.specflow.Specflow
{
    public class BasePage
    {
        //wait for element existence
        public static bool WaitUntilElementExists(IWebDriver driver, By elementLocator, int timeout = 10)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(timeout));
                wait.Until(d => driver.FindElement(elementLocator));
                FocusElement(driver, elementLocator); //set focus to element
                return true;
            }
            catch (Exception) //catch all exception types and dispose the driver
            {
                return false;
            }
        }
        //set focus to element
        public static void FocusElement(IWebDriver driver, By elementLocator)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(elementLocator));
            actions.Perform();
        }
        public static bool VerifyBrowserTitle(IWebDriver driver, string expectedValue)
        {
            string actualvalue = driver.Title;
            if ((!actualvalue.Equals(expectedValue)) && (!actualvalue.Contains(expectedValue)))
            {
                return false;
            }
            else { return true; }
        }
    }
}
