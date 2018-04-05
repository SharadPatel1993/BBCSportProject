using OpenQA.Selenium;
using BBCSportProject.Helpers;
using OpenQA.Selenium.Support.PageObjects;

namespace BBCSportProject.Pages
{
    public class BasePage
    {
        internal BasePage(IWebDriver driver, By pageSelector)
        {
            Waits.WaitForElementToExist(driver, pageSelector);
            PageFactory.InitElements(driver, this);
        }
    }
}
