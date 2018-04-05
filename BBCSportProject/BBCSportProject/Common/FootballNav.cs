using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Common
{
    internal class FootballNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("ul[class='secondary-nav__items secondary-nav__items--not-shortcuts']");

        internal FootballNav(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class=' secondary-nav__item   '] a[href='/sport/football/tables']")] private IWebElement TablesLink;

        internal void ClickTablesLink()
        {
            TablesLink.Click(Driver);
        }
    }
}
