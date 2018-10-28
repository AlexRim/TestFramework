
using AllStarsSolution.DriverCore;
using AllStarsSolution.WebDriver;
using OpenQA.Selenium;
using System;

namespace AllStarsSolution.DriverExtensions
{
    public static class DriverExtension
    {
        public static void Click(IWebElement element) => Browser.InvokeAction(action => element.Click());

        public static IWebElement GetElement(By locator) => Browser.InvokeFunc<IWebElement>(element => element.FindElement(locator));

    }
}
