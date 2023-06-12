using NBAWebsiteAutomation.Source.Drivers;
using NBAWebsiteAutomation.Source.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NBAWebsiteAutomation.Tests
{
    public class TestHomePage : Driver
    {
        /* Redirection to current home page */
        [Test]
        public void RedirectionHome()
        {
            HomePage nhp = new HomePage();
            _driver.Navigate().GoToUrl("https://www.nba.com");
            nhp.Home();
            Assert.True(_driver.Title.Contains("The official site of the NBA for the latest NBA Scores, Stats & News. | NBA.com"));
        }

        /* Utilizes search bar to locate players within given list and confirms it is located within the players section */
        [Test]
        public void SearchSpecificPlayer()
        {
            HomePage nhp = new HomePage();
            _driver.Navigate().GoToUrl("https://www.nba.com");
            nhp.Search("Stephen Curry");
            Assert.True(_driver.PageSource.Contains("Players"));
        }

        /* Locates all previously and current played matches and hides the score using a slider */
        [Test]
        public void SeeAllGamesThenHideScores()
        {
            HomePage nhp = new HomePage();
            _driver.Navigate().GoToUrl("https://www.nba.com");
            nhp.HideScores();
            Assert.True(_driver.Title.Contains("NBA Games - All NBA matchups | NBA.com"));
        }

        /* Execution of multiple actions then returning home */
        [Test]
        public void NBAScheduleAndRedirectionHome()
        {
            HomePage nhp = new HomePage();
            _driver.Navigate().GoToUrl("https://www.nba.com");
            nhp.NBAScheduleWithRedirection();
            Assert.True(_driver.Title.Contains("The official site of the NBA for the latest NBA Scores, Stats & News. | NBA.com"));

        }
        }
    }
