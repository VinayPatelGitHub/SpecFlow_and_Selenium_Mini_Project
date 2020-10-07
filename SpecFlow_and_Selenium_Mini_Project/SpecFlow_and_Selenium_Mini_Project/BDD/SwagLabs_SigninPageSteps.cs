using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SpecFlow_and_Selenium_Mini_Project
{
    [Binding]
    public class SwagLabs_SigninPageSteps
    {
        public SwagLabs_Website SwagLabs_Website { get; } = new SwagLabs_Website();

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            SwagLabs_Website.SwagLabs_SigninPage.VisitSignInPage();
        }

        [Given(@"I have/haven't entered a username (.*)")]
        public void GivenIHaveHavenTEnteredAUsername(string usernames)
        {
            SwagLabs_Website.SwagLabs_SigninPage.EnterUsername(usernames);
        }

        [Given(@"I have/haven't entered a password (.*)")]
        public void GivenIHaveHavenTEnteredAPassword(string password)
        {
            SwagLabs_Website.SwagLabs_SigninPage.EnterPassword(password);
        }

        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            SwagLabs_Website.SwagLabs_SigninPage.ClickSignIn();
        }

        [Then(@"I should be taken to the login page with title header ""(.*)""")]
        public void ThenIShouldBeTakenToTheLoginPageWithTitleHeader(string header)
        {
            Assert.That(SwagLabs_Website.SwagLabs_SigninPage.SuccessfulSigninText(), Does.Contain(header));
        }

        [Then(@"I should see a alert which says (.*)")]
        public void ThenIShouldSeeAAlertWhichSays(string alert)
        {
            Assert.That(SwagLabs_Website.SwagLabs_SigninPage.GetAlertText(), Does.Contain(alert));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            SwagLabs_Website.SeleniumDriver.Quit();
            SwagLabs_Website.SeleniumDriver.Dispose();
        }
    }
}
