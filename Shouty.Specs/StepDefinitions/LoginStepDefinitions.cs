using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Shouty.Specs.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://manager.easyclaimsph.com/Account/Login?ReturnUrl=%2F"); // Replace with your login page URL
        }

        [When(@"the user enters valid credentials")]
        public void WhenTheUserEntersValidCredentials()
        {
            driver.FindElement(By.Id("Username")).SendKeys("patche1214");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("1234567");
            driver.FindElement(By.Id("submitBtn")).Click();
        }

        [When(@"the user enters invalid credentials")]
        public void WhenTheUserEntersInvalidCredentials()
        {
            driver.FindElement(By.Id("Username")).SendKeys("patasdche1214");
            driver.FindElement(By.Id("Password")).SendKeys("1as2346");
            driver.FindElement(By.Id("submitBtn")).Click();
        }

        [Then(@"the user should be redirected to the homepage")]
        public void ThenTheUserShouldBeRedirectedToTheHomepage()
        {
            Assert.Equal("https://manager.easyclaimsph.com/", driver.Url); // Replace with your homepage URL
            driver.Quit();
        }

        [Then(@"an error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            var errorMessageElement = driver.FindElement(By.TagName("li"));

            // Extract the text from the element
            var errorMessage = errorMessageElement.Text;

            // Verify the error message content
            Assert.Equal("The username and password you entered does not match or does not exist. Please try again.", errorMessage);

            // Quit the driver
            driver.Quit();
        }
    }
}
