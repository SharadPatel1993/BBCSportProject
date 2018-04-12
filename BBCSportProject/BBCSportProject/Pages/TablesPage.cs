using System.Collections.Generic;
using BBCSportProject.Navs;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCSportProject.Pages
{
    public class TablesPage : BasePage
    {
        private IWebDriver Driver { get; }
        private static readonly By pageSelector = By.Id("page");
        private SportNav SportNav => new SportNav(Driver);
        private FootballNav FootballNav => new FootballNav(Driver);

        public TablesPage(IWebDriver driver) : base(driver, pageSelector)
        {
            Driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "td abbr")] private IList<IWebElement> Teams = null;

        public string GetTeamInPostion(int position)
        {
            return GetTeamsList()[position - 1];
        }

        public int GetTeamPosition(string team)
        {
            return GetTeamsList().IndexOf(team.ToUpper()) + 1;
        }

        private List<string> GetTeamsList()
        {
            List<string> teamsList = new List<string>();

            foreach (IWebElement teamRow in Teams)
            {
                teamsList.Add(teamRow.GetAttribute("title").ToUpper());
            }

            return teamsList;
        }
    }
}
