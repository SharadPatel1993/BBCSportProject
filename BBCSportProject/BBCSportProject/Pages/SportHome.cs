using BBCSportProject.Common;
using BBCSportProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Pages
{
    public class SportHome : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("sport-container");
        private SportNav sportNav => new SportNav(Driver);

        public SportHome(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public void ClickFootballLink()
        {
            sportNav.ClickFootballLink();
        }
    }
}
