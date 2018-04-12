using BBCSportProject.Navs;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class SportHomePage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("sport");
        private BBCNav BBCNav => new BBCNav(Driver);
        private SportNav SportNav => new SportNav(Driver);

        public SportHomePage(IWebDriver driver) : base(driver, pageSelector, true)
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
