using BBCSportProject.Common;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class SportHomePage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("sport-container");
        private BBCNav BBCNav => new BBCNav(Driver);
        private SportNav SportNav => new SportNav(Driver);

        public SportHomePage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public FootballPage ClickFootballLink()
        {
            SportNav.ClickFootballLink();
            return new FootballPage(Driver);
        }
    }
}
