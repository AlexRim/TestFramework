
using AllStarsSolution.DriverCore;
using AllStarsSolution.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AllStarsSolution.WebDriver
{
    public static class Browser
    {

        private static readonly IWebDriver driver;

        private static Browsers currentBrowser;

        private static string browserName;

        public static double timeOut;

        public static IWebDriver Driver => driver ?? BrowserFactory.GetDriver(currentBrowser);

        private static IWebDriver WebDriver => driver;



        public static T InvokeFunc<T>(Func<IWebDriver, T> func)
        {
            //this.VerifyIsDisposed();
            return func != null ? func(driver) : default(T);
        }
        public static void InvokeAction(Action<IWebDriver> action)
        {
          //  this.VerifyIsDisposed();
            action?.Invoke(driver);
        }


         static Browser()
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

        public static void Navigate() => Driver.Navigate().GoToUrl(Configuration.StartUrl);

        public static void Quit()
        {
            driver.Close();
            driver.Quit();
        }
        

    }
}
