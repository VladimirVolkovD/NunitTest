using Core.Configuration;
using Core.Selenium;
using NUnit.Framework;
using NunitTest.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTest.Test.SwagLabs
{
    internal class BaseTest
    {
        protected IWebDriver Driver = Browser.Instance.Driver;
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            Driver = Browser.Instance.Driver;
            LoginPage = new LoginPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
