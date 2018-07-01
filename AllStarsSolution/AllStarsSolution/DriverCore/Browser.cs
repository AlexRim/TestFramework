
using AllStarsSolution.DriverCore;
using AllStarsSolution.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AllStarsSolution.WebDriver
{
    public class Browser
    {
        private static Browser browser;

        private static IWebDriver driver;

        private static Browsers currentBrowser;

        private static string browserName;

        public static double timeOut;

        public static Browser Driver => browser ?? (browser = new Browser());

        public static IWebDriver GetDriver() => driver;


        private Browser()
        {
            InitParams();
            driver = BrowserFactory.GetDriver(currentBrowser);
        }


        private static void InitParams()
        {
            browserName = Configuration.Browser;

            timeOut = Convert.ToDouble(Configuration.TimeOut);
            
            Enum.TryParse(browserName, out currentBrowser);

        }

        public static void Navigate() => GetDriver().Navigate().GoToUrl(Configuration.StartUrl);
    
    }
}
