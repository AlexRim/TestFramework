using AllStarsSolution.DriverCore;
using AllStarsSolution.WebDriver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
     public  class SmokeTest
    {
        [Test]
        public void Test()
        {
            Browser.Driver.Navigate().GoToUrl(Configuration.StartUrl);
            Browser.Quit();

        }

        [Test]
        public void Test2()
        {

            Browser.Driver.Navigate().GoToUrl(Configuration.StartUrl);
            Browser.Quit();
           

        }

        [Test]
        public void Test3()
        {
            Browser.Driver.Navigate().GoToUrl(Configuration.StartUrl);
            Browser.Quit();


        }

    }
}
