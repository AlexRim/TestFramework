using AllStarsSolution.Core;
using AllStarsSolution.Enums;
using AllStarsSolution.WebDriverCreators;
using AllStarsSolution.WebDrivers;
using OpenQA.Selenium;
using System;

namespace AllStarsSolution.WebDriver
{
    public class BrowserFactory
    {
       
        public static IWebDriver GetDriver(Browsers type)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case Browsers.Chrome:
                {
                        driver = new ChromeDriverCreator().CreateWebDriver();
                        break;
                }
                case Browsers.FireFox:
                {
                        driver = new FireFoxDriverCreator().CreateWebDriver();
                        break;
                }
                default:
                {
                        throw new Exception("Unknown browser type!");
                }
            }
            return driver;
        }
    }
}
