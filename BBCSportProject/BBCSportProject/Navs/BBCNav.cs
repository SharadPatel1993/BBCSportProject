using BBCSportProject.Helpers;
using BBCSportProject.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCSportProject.Navs
{
    internal class BBCNav : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("orb-header");

        internal BBCNav(IWebDriver driver) : base(driver, pageSelector, true)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "li[class='orb-nav-sport']")] private IWebElement SportLink = null;

        internal void ClickSportLink()
        {
            SportLink.Click(Driver);
        }
    }

}
