using BBCSportProject.Navs;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class BBCHomePage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("hp-bbc-homepage-content");
        private BBCNav BBCNav => new BBCNav(Driver);

        public BBCHomePage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public SportHomePage ClickSportLink()
        {
            BBCNav.ClickSportLink();
            return new SportHomePage(Driver);
        }
    }
}
