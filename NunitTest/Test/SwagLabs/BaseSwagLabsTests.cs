using NUnit.Framework;

namespace NunitTest.Test.SwagLabs
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
