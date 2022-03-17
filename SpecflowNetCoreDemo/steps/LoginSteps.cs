using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNetCoreDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNetCoreDemo.steps
{
    [Binding]
    public sealed class LoginSteps
    {
        LoginPages loginPage = null;
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            // ScenarioContext.Current.Pending();
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginPage = new LoginPages(webDriver);
        }

        [Given(@"I cick login link")]
        public void GivenICickLoginLink()
        {
            //ScenarioContext.Current.Pending();
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            //ScenarioContext.Current.Pending();
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.UserName, (string)data.Password);
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            //ScenarioContext.Current.Pending();
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
