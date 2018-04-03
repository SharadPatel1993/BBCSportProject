using BBCSportProject.Common;
using OpenQA.Selenium;

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

        public FootballPage ClickFootballLink()
        {
            sportNav.ClickFootballLink();
            return new FootballPage(Driver);
        }
    }
}
