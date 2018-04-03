﻿using BBCSportProject.Common;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class FootballPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("sport-container");
        private SportNav sportNav => new SportNav(Driver);
        private FootballNav footballNav => new FootballNav(Driver);

        public FootballPage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public SportHome ClickHomeLink()
        {
            sportNav.ClickHomeLink();
            return new SportHome(Driver);
        }

        public TablesPage ClickTablesLink()
        {
            footballNav.ClickTablesLink();
            return new TablesPage(Driver);
        }

    }
}
