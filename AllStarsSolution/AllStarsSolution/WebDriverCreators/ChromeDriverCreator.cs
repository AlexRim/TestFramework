using AllStarsSolution.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AllStarsSolution.WebDrivers
{
    public class ChromeDriverCreator : IDriverCreate
    {
        public IWebDriver CreateWebDriver()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(
                "--start-maximized",                 
                "--ignore-certificate-errors", 
                "--incognito",
                "disable-infobars");
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(), chromeOptions);
        }
    }
}
