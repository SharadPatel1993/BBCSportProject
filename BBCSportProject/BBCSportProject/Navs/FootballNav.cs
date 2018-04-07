using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCSportProject.Navs
{
    internal class FootballNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("nav[class*='secondary-nav']");

        internal FootballNav(IWebDriver driver) : base(driver, pageSelector, true)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class=' secondary-nav__item   '] a[href='/sport/football/tables']")] private IWebElement TablesLink = null;

        internal void ClickTablesLink()
        {
            TablesLink.Click(Driver);
        }
    }
}
