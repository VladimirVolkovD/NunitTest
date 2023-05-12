using Core.Selenium;
using NUnit.Framework;

namespace NunitTest.Test.SwagLabs
{
    internal class SwagLabsBaseTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Instance.Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
