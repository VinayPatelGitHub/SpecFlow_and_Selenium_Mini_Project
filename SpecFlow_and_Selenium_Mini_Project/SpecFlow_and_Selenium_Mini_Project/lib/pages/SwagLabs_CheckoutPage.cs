using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_and_Selenium_Mini_Project
{
    public class SwagLabs_CheckoutPage
    {
        private IWebDriver _driver;
        private IWebElement _basketCartContents => _driver.FindElement(By.Id("cart_contents_container"));
        private IWebElement _removeItemButton => _driver.FindElement(By.CssSelector(".cart_button"));





        public SwagLabs_CheckoutPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal string ReturnIteminBasketname()
        {
            return _basketCartContents.Text;
        }
        internal void ClickRemoveItem()
        {
            _removeItemButton.Click();
        }
    }
}
