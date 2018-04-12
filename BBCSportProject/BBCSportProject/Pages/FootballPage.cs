using BBCSportProject.Navs;
using OpenQA.Selenium;

namespace BBCSportProject.Pages
{
    public class FootballPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("page");
        private BBCNav BBCNav => new BBCNav(Driver);
        private SportNav SportNav => new SportNav(Driver);
        private FootballNav FootballNav => new FootballNav(Driver);

        public FootballPage(IWebDriver driver) : base(driver, pageSelector, true)
        {
            Driver = driver;
        }

        public TablesPage ClickTablesLink()
        {
            FootballNav.ClickTablesLink();
            return new TablesPage(Driver);
        }

    }
}
