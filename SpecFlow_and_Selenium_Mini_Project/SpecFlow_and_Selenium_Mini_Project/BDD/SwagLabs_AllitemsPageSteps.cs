using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_and_Selenium_Mini_Project.BDD
{
    [Binding]
    public class SwagLabs_AllitemsPageSteps
    {
        public SwagLabs_Website SwagLabs_Website { get; } = new SwagLabs_Website();

        [Given(@"I am on the AllitemsPage")]
        public void GivenIAmOnTheAllitemsPage()
        {
            SwagLabs_Website.SwagLabs_SigninPage.VisitSignInPage();
            SwagLabs_Website.SwagLabs_SigninPage.EnterUsername("standard_user");
            SwagLabs_Website.SwagLabs_SigninPage.EnterPassword("secret_sauce");
        }

        [Given(@"I add item to basket")]
        public void GivenIAddItemToBasket()
        {
            SwagLabs_Website.SwagLabs_AllitemsPage.ClickAddFirstItemToBasket();
        }
        
        [When(@"I click the basket")]
        public void WhenIClickTheBasket()
        {
            SwagLabs_Website.SwagLabs_AllitemsPage.ClickBasket();
        }
        
        [Then(@"I should see the item ""(.*)"" in basket")]
        public void ThenIShouldSeeTheItemInBasket(string itemName)
        {
            Assert.That(SwagLabs_Website.SwagLabs_AllitemsPage.ReturnIteminBasketname(), Does.Contain(itemName));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            SwagLabs_Website.SeleniumDriver.Quit();
            SwagLabs_Website.SeleniumDriver.Dispose();
        }
    }
}
