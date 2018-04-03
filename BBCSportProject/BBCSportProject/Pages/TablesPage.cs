using System;
using System.Collections.Generic;
using BBCSportProject.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Pages
{
    public class TablesPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("h1[id='page']");
        private SportNav sportNav => new SportNav(Driver);
        private FootballNav footballNav => new FootballNav(Driver);

        public TablesPage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "td abbr[class='sp-u-abbr-on sp-u-abbr-off@m']")] private IList<IWebElement> Teams;

        public void GetTeamInPostion(int position)
        {
            //TODO
        }
    }
}
