using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime.CompilerServices;

namespace pom.specflow.Specflow
{
    public class BasePage
    {
        //wait for element existence
        public static bool WaitUntilElementExists(IWebDriver driver,
            By elementLocator,
            int timeout = 10,
            [CallerMemberName] string methodName="")
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(timeout));
                wait.Until(d => driver.FindElement(elementLocator));
                FocusElement(driver, elementLocator); //set focus to element
                return true;
            }
            catch (Exception)
            {
                throw new Exception($"Error occurred in \"{methodName}\" method." +
                    $"\nUnable to find element using \"{elementLocator}\" locator.");
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
                throw new Exception($"Expected title \"{expectedValue}\" didn't matched the actual title \"{actualvalue}\" displayed");
            }
            else { return true; }
        }
        public static void ClickElement(IWebDriver driver, By elementLocator)
        {
            WaitUntilElementExists(driver, elementLocator);
            FocusElement(driver, elementLocator);
            driver.FindElement(elementLocator).Click();
        }
        public static void EnterText(IWebDriver driver, By elementLocator, string s)
        {
            WaitUntilElementExists(driver, elementLocator);
            FocusElement(driver, elementLocator);
            driver.FindElement(elementLocator).SendKeys(s);
        }
    }
}