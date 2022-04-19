
using AllStarsSolution.DriverCore;
using AllStarsSolution.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace AllStarsSolution.WebDriver
{
    public class Browser
    {

        private static  IWebDriver driver = null;

        private static Browsers currentBrowser;

        private static string browserName;

        public static double timeOut;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = BrowserFactory.GetDriver(currentBrowser);
                }
                return driver;
            }
        }
    
        


        public  static  T InvokeFunc<T>(Func<IWebDriver, T> func)
        {         
            //this.VerifyIsDisposed();
            return func != null ? func(driver) : default(T);
        }
        public static void InvokeAction(Action<IWebDriver> action)
        {
          //  this.VerifyIsDisposed();
            action?.Invoke(driver);
        }
        private static int count = 0;
        private static IList<IWebDriver> list = new List<IWebDriver>();

         public Browser()
        {
            InitParams();
        }


        private static void InitParams()
        {
            browserName = Configuration.Browser;
            timeOut = Convert.ToDouble(Configuration.TimeOut);           
            Enum.TryParse(browserName, out currentBrowser);

        }

        public static void Navigate() =>Driver.Navigate().GoToUrl(Configuration.StartUrl);
        public static void Quit()
        {
            Driver.Close();
            Driver.Quit();
            driver=null;
        }      
    }
}
