using AllStarsSolution.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AllStarsSolution.WebDriverCreators
{
    public class FireFoxDriverCreator : IDriverCreate
    {
        public IWebDriver CreateWebDriver()
        {
            var fireFoxOptions = new FirefoxOptions();
            fireFoxOptions.AddArguments(
                "--start-maximized",
                "--ignore-certificate-errors",
                "--incognito",
                "disable-infobars");
            return new FirefoxDriver(FirefoxDriverService.CreateDefaultService(), fireFoxOptions);
        }
    }
}
