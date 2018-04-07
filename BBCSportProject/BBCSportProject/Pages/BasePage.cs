using BBCSportProject.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCSportProject.Pages
{
    public class BasePage
    {
        internal BasePage(IWebDriver driver, By pageSelector, bool searchContext = false)
        {
            Waits.WaitForElementToExist(driver, pageSelector);
            if (searchContext)
            {
                PageFactory.InitElements(driver.FindElement(pageSelector), this);
            }
            else
            {
                PageFactory.InitElements(driver, this);
            }
        }
    }
}
