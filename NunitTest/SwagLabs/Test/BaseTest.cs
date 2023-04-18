using NUnit.Framework;
using NunitTest.SwagLabs.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTest.SwagLabs.Test
{
    internal class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            LoginPage = new LoginPage(ChromeDriver);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
