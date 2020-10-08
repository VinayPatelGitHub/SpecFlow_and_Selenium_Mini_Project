using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_and_Selenium_Mini_Project
{
    
    public class SwagLabs_AllitemsPage
    {
        private IWebDriver _driver;
        private IWebElement _addd1stItemButton => _driver.FindElement(By.CssSelector(".inventory_item:nth-child(1) .btn_primary"));
        private IWebElement _basketButton => _driver.FindElement(By.CssSelector("path"));
        private IWebElement _menuButton => _driver.FindElement(By.ClassName("bm-burger-button"));
        private IWebElement _logoutButton => _driver.FindElement(By.Id("logout_sidebar_link"));
               
                
        public SwagLabs_AllitemsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void ClickAddFirstItemToBasket()
        {
            _addd1stItemButton.Click();
        }
        internal void ClickBasket()
        {
            _basketButton.Click();
        }
        
        internal void ClickMenu()
        {
            _menuButton.Click();
        }
        internal void ClickLogout()
        {
            _logoutButton.Click();
        }

        

    }
}
