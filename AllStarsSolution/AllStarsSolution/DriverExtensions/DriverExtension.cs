
using AllStarsSolution.DriverCore;
using AllStarsSolution.WebDriver;
using OpenQA.Selenium;
using System;

namespace AllStarsSolution.DriverExtensions
{
    public static class DriverExtension
    {
        public static void WaitForPageLoad()
        {
            Browser.GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Browser.timeOut);
        }

        public static IWebElement GetElement(By locator)
        {
            var wait
        }


    }
}
