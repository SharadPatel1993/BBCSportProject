using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCSportProject.Navs
{
    internal class SportNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("nav[class*='primary-nav']");

        internal SportNav(IWebDriver driver) : base(driver, pageSelector, true)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class=' primary-nav__item   '] a[href$='/football']")] private IWebElement FootballLink = null;

        internal void ClickFootballLink()
        {
            FootballLink.Click(Driver);
        }

    }
}
