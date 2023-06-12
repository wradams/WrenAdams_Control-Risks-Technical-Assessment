using NBAWebsiteAutomation.Source.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using NBAWebsiteAutomation.Source.Drivers;

namespace NBAWebsiteAutomation.Tests
{
    public class TestLogin : Driver
    {
        //Please note Unable to pass reCaptcha as Captcha element is not to be interactable by test means
        [Test]
        public void InvalidLoginDetails()
        {
            LoginPage nlp = new LoginPage();
            _driver.Navigate().GoToUrl("https://www.nba.com");
            nlp.Login("testuser@gmail.com", "testpass");
            Assert.True(_driver.Title.Contains("NBA Login | NBA.com"));
        }
    }
}
