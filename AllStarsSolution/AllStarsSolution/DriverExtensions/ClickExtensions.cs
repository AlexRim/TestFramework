
using OpenQA.Selenium;
using System;

namespace AllStarsSolution.DriverExtensions
{
   public static class ClickExtensions
    {
       

        public static void Click(IWebElement driver, By locator)
        {
            try
            {
                driver.FindElement(locator).Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
