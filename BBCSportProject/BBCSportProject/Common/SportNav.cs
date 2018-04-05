using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Common
{
    internal class SportNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("div[class=' nav-top  ']");

        internal SportNav(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class=' primary-nav__item   '] a[href='/sport/football']")] private IWebElement FootballLink;

        internal void ClickFootballLink()
        {
            FootballLink.Click(Driver);
        }

    }
}
