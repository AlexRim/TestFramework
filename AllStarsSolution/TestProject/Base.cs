
namespace TestProject
{
    using AllStarsSolution.WebDriver;
    using NUnit.Framework;
    using NUnit.Framework;
    [TestFixture]
    public class Base
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Navigate();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Quit();
        }

    }

}
