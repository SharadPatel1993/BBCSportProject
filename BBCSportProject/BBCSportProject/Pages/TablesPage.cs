using System;
using BBCSportProject.Common;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class TablesPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("u6527958374936134");
        private SportNav sportNav => new SportNav(Driver);
        private FootballNav footballNav => new FootballNav(Driver);

        public TablesPage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }
    }
}
