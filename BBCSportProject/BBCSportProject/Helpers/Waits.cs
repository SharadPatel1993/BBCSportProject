using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BBCSportProject.Helpers
{
    internal static class Waits
    {
        private static readonly TimeSpan TimeOut = TimeSpan.FromSeconds(20);

        internal static bool WaitForElementToExist(IWebDriver driver, By pageSelector)
        {
            return WaitCondition(driver, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pageSelector));
        }

        internal static bool WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            return WaitCondition(driver, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        private static bool WaitCondition(IWebDriver driver, Func<IWebDriver, IWebElement> expectedConditions)
        {
            var wait = new WebDriverWait(driver, TimeOut);
            var element = wait.Until(expectedConditions);
            if (element == null) throw new NoSuchElementException();
            return true;
        }
    }
}
