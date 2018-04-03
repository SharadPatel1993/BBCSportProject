using System;
using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Common
{
    internal class BBCNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("orb-modules");

        internal BBCNav(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class='orb-nav-sport']")] private IWebElement SportLink;

        internal void ClickSportLink()
        {
            SportLink.Click(Driver);
        }
    }

}
