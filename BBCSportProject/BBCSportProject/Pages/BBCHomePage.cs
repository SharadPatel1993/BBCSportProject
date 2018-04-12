using BBCSportProject.Navs;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class BBCHomePage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("div[role='main']");
        private BBCNav BBCNav => new BBCNav(Driver);

        public BBCHomePage(IWebDriver driver) : base(driver, pageSelector, true)
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
