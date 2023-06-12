using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;

namespace NBAWebsiteAutomation.Source.Drivers
{
    public class Driver
    {
        [ThreadStatic]
        public static IWebDriver _driver;

        // Initialization of webdriver used to probe a website
        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        // After execution, ends all processes after confimation of test completion
        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
