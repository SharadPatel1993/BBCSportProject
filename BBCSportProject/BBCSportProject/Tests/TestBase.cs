using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace BBCSportProject.Tests
{
    public class TestBase
    {
        public IWebDriver Driver { get; set; }
        public static Uri GridWebDriverUrl { get; set; } = new Uri("http://localhost:4444/wd/hub");

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Driver = new RemoteWebDriver(GridWebDriverUrl, new ChromeOptions().ToCapabilities());
        }

        [SetUp]
        public void SetUp()
        {
            Driver.Navigate().GoToUrl("http://www.bbc.co.uk/");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Driver?.Quit();
        }
    }
}
