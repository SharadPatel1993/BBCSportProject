using BBCSportProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Pages
{
    public class SportHome : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.CssSelector("div[class='b-pw-1280']");

        public SportHome(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='/sport/football']")] private IWebElement FootballLink;

        public void ClickFootballLink()
        {
            FootballLink.Click(Driver);
        }
    }
}
