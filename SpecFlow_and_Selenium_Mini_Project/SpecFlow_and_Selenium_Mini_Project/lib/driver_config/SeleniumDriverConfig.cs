using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_and_Selenium_Mini_Project
{
    class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, pageLoadInSecs, implicitWaitInSecs);
        }

        public void DriverSetUp(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driver.ToLower() == "chrome")
            {
                SetChromeDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else if (driver.ToLower() == "firefox")
            {
                SetFireFoxDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }
            else
            {
                throw new Exception("Please use 'chrome' or 'firefox'");
            }
        }
        public void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }
        public void SetFireFoxDriver()
        {
            Driver = new FirefoxDriver();
        }
        public void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }

    }
}
