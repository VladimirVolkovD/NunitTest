using Core.Configuration;
using NUnit.Framework;
using NunitTest.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTest.Test.SwagLabs
{
    internal class BaseTest
    {
        protected WebDriver ChromeDriver { get; set; }
        public LoginPage LoginPage { get; set; }

        [SetUp]
        public void SetUp()
        {
            string browser = TestContext.Parameters.Get("Browser");
            bool headless = Configuration.Browser.Headless;
            switch(browser)
            {
                case "headless":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    ChromeDriver = new ChromeDriver(options);
                    break;
                default:
                    ChromeDriver = new ChromeDriver();
                    break;
            }

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
