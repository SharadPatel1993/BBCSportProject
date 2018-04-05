using OpenQA.Selenium;

namespace BBCSportProject.Helpers
{
    internal static class Extensions
    {
        internal static IWebElement Click(this IWebElement element, IWebDriver driver)
        {
            Waits.WaitForElementToBeClickable(driver, element);
            element.Click();
            return element;
        }
    }
}
