using NBAWebsiteAutomation.Source.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NBAWebsiteAutomation.Source.Pages
{
    public class HomePage : Driver
    {
        /* Initializes Elements using css to pinpoint each testing field
        Could use How.Id to make it simpler and easier to understand if NBA website utilized Ids */
        [FindsBy(How = How.CssSelector, Using = "img[src='https://cdn.nba.com/logos/leagues/logo-nba.svg']")]
        public IWebElement _home;

        [FindsBy(How = How.CssSelector, Using = "img[title='NBA Logo']")]
        public IWebElement _homelogo;

        [FindsBy(How = How.CssSelector, Using = ".Anchor_anchor__cSc3P.NavDropdownChild_link__NSYfR[href='/account/sign-in']")]
        public IWebElement _loginlink;

        [FindsBy(How = How.CssSelector, Using = ".Anchor_anchor__cSc3P.NavItem_link__ZBDtq[href='/players']")]
        private IWebElement _playersbtn;

        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Search Players']")]
        private IWebElement _searchtextbox;

        [FindsBy(How = How.CssSelector, Using = ".Anchor_anchor__cSc3P.Scoreboard_link__OgzVW.Link_styled__okbXW")]
        private IWebElement _seeallgamesbtn;

        [FindsBy(How = How.CssSelector, Using = ".Toggle_slider__ln3dZ[data-track='click']")]
        private IWebElement _hidescoresslider;

        [FindsBy(How = How.CssSelector, Using = ".Anchor_anchor__cSc3P.NavItem_link__ZBDtq[href='/schedule']")]
        private IWebElement _nbaschedule;

        [FindsBy(How = How.CssSelector, Using = ".Anchor_anchor__cSc3P.SubNavItem_subnavLink__pF1m7[href='/news/key-dates']")]
        private IWebElement _nbakeydates;


        /* Methods used to run the WebElements and provide information to Unitests */
        public HomePage() 
        {
            PageFactory.InitElements(_driver, this);
        }

        public void Home()
        {
            _home.Click();
        }

        public void Search(string searchtext)
        {
            _playersbtn.Click();
            _searchtextbox.SendKeys(searchtext);
        }

        public void HideScores()
        {
            _seeallgamesbtn.Click();
            _hidescoresslider.Click();
        }

        public void NBAScheduleWithRedirection()
        {
            _nbaschedule.Click();
            _nbakeydates.Click();
            _homelogo.Click();
        }
    }
}
