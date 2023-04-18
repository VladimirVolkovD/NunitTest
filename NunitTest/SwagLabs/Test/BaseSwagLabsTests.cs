using NUnit.Framework;

namespace NunitTest.SwagLabs.Test
{
    internal class SwagLabsBaseTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
