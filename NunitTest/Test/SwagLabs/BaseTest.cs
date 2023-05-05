using Core.Selenium;
using NUnit.Framework;
using NunitTest.Page;
using OpenQA.Selenium;

namespace NunitTest.Test.SwagLabs
{
    internal class BaseTest
    {
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {       
            LoginPage = new LoginPage();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
