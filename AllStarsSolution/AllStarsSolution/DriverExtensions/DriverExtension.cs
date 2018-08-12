
using AllStarsSolution.DriverCore;
using AllStarsSolution.WebDriver;
using OpenQA.Selenium;
using System;

namespace AllStarsSolution.DriverExtensions
{
    public static class DriverExtension
    {
      public static void Click(IWebElement element) =>Browser.Driver.InvokeAction(action => element.Click());

      public static IWebElement GetElement(By locator) =>Browser.Driver.InvokeFunc<IWebElement>(element => element.FindElement(locator));



    }
}
