using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_and_Selenium_Mini_Project
{
    public class SwagLabs_SigninPage
    {
        private IWebDriver _driver;
        private string _signInPageURL = AppConfigReader.BaseUrl;
        private IWebElement _usernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("password"));
        private IWebElement _signinButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement _alertfield => _driver.FindElement(By.CssSelector("*[data-test=\"error\"]"));
        private IWebElement _productPageHeaderfield => _driver.FindElement(By.CssSelector(".product_label"));

        public SwagLabs_SigninPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void VisitSignInPage()
        {
            _driver.Navigate().GoToUrl(_signInPageURL);
        }
        internal void EnterUsername(string username)
        {
            _usernameField.SendKeys(username);
        }
        internal void EnterPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
        internal void ClickSignIn()
        {
            _signinButton.Click();
        }
        internal string GetAlertText()
        {
            return _alertfield.Text;
        }
        internal string SuccessfulSigninText()
        {
            return _productPageHeaderfield.Text;
        }


    }
}
