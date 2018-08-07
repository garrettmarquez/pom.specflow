using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;

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
            //dynamic driver folder path
            string driver_path = $@"{Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"))}\Drivers\";
            //use default browser
            switch (TestContext.Parameters.Get("Browser", GetDefaultBrowser()).ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver(driver_path, GetChromeDefaultOptions());
                    break;
                case "headless": //run chrome in headless mode
                    ChromeOptions options = GetChromeDefaultOptions();
                    options.AddArguments("--headless");
                    options.AddArguments("--disable-gpu");
                    options.AddArguments("--window-size=1920,1080");
                    driver = new ChromeDriver(driver_path, options);
                    break;
                case "firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    driver = new FirefoxDriver(service);
                    break;
                default:
                    break;
            }
            return driver;
        }
        public void Close()
        {
            driver.Close();
            driver.Quit();
        }
        //default chrome options
        private static ChromeOptions GetChromeDefaultOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("test-type");
            options.AddArguments("--disable-popup-blocking");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignoreProtectedModeSettings");
            return options;
        }
        //private static string browser = "Chrome"; //get default browser
        private static string GetDefaultBrowser() => "chrome";
    }
}
