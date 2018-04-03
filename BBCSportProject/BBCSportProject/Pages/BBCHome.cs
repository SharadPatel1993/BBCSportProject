using BBCSportProject.Common;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class BBCHome : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("hp-bbc-homepage-content");
        private BBCNav sportNav => new BBCNav(Driver);

        public BBCHome(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public SportHome ClickSportLink()
        {
            sportNav.ClickSportLink();
            return new SportHome(Driver);
        }
    }
}
