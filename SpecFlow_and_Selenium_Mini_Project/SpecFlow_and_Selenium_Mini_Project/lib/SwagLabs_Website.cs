using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_and_Selenium_Mini_Project
{
    public class SwagLabs_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public SwagLabs_SigninPage SwagLabs_SigninPage { get; internal set; }
        public SwagLabs_AllitemsPage SwagLabs_AllitemsPage { get; internal set; }
        public SwagLabs_CheckoutPage SwagLabs_CheckoutPage { get; internal set; }

        public SwagLabs_Website(string driver = "chrome", int pageLoadInSecs = 10, int implicitWaitInSecs = 10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driver, pageLoadInSecs, implicitWaitInSecs).Driver;
            SwagLabs_SigninPage = new SwagLabs_SigninPage(SeleniumDriver);
            SwagLabs_AllitemsPage = new SwagLabs_AllitemsPage(SeleniumDriver);
            SwagLabs_CheckoutPage = new SwagLabs_CheckoutPage(SeleniumDriver);
        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }

    }

    
}
