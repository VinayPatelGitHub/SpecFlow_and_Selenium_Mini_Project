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
        private IWebElement _backetCartContents => _driver.FindElement(By.Id("cart_contents_container"));

        
        private IWebElement _item0 => _driver.FindElement(By.CssSelector("#item_0_img_link > .inventory_item_img"));
        private IWebElement _item1 => _driver.FindElement(By.CssSelector("#item_1_img_link > .inventory_item_img"));
        private IWebElement _item2 => _driver.FindElement(By.CssSelector("#item_2_img_link > .inventory_item_img"));
        private IWebElement _itemName => _driver.FindElement(By.ClassName("inventory_details_name"));
                
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
        internal string ReturnIteminBasketname()
        {            
            return _backetCartContents.Text;
        }


    }
}
