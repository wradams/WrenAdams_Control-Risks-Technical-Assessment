using NBAWebsiteAutomation.Source.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAWebsiteAutomation.Source.Pages
{
    public class LoginPage : Driver
    {
        IWebDriver _webdriver;

        [FindsBy(How = How.CssSelector, Using = "#email")]
        private IWebElement _emailtext;

        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement _passwordtext;

        [FindsBy(How = How.CssSelector, Using = "#submit")]
        private IWebElement _submitbtn;

        public LoginPage()
        {
            PageFactory.InitElements(_driver, this);
        }

        public void Login(string username, string password)
        {
            HomePage nhp = new HomePage();
            nhp._loginlink.Click();
            _emailtext.SendKeys(username);
            _passwordtext.SendKeys(password);
            _submitbtn.Click();
        }
    }
}
