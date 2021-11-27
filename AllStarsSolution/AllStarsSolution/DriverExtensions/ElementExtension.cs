using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllStarsSolution.DriverExtensions
{
    public static  class ElementExtension
    {
        public static IWebElement GetElement(IWebDriver driver, By locator) => driver.FindElement(locator);

        public static IReadOnlyCollection<IWebElement> GetElements(IWebDriver driver, By locator) => driver.FindElements(locator);
    }
}
