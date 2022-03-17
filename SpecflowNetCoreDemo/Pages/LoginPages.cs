using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowNetCoreDemo.Pages
{
    public class LoginPages
    {
        public IWebDriver WebDriver { get; }

        public LoginPages(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement TextUserName => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement TextPassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeDetails => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public void ClickLogin() => lnkLogin.Click();
        public void Login(string username , string password)
        {
            TextUserName.SendKeys(username);
            TextPassword.SendKeys(password);
        }
        public void ClickLoginButton() => btnLogin.Submit();
        public bool IsEmployeeDetailsExist() => lnkEmployeDetails.Displayed;


    }
}
