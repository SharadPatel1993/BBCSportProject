using BBCSportProject.Common;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class FootballPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("sport-container");
        private SportNav sportNav => new SportNav(Driver);

        public FootballPage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        public void ClickHomeLink()
        {
            sportNav.ClickHomeLink();
        }

    }
}
