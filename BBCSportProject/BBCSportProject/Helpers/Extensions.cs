using OpenQA.Selenium;

namespace BBCSportProject.Helpers
{
    public static class Extensions
    {
        public static IWebElement Click(this IWebElement element, IWebDriver driver)
        {
            Waits.WaitForElementToBeClickable(driver, element);
            element.Click();
            return element;
        }
    }
}
