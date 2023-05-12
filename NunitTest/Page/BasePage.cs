using OpenQA.Selenium;

namespace NunitTest.Page
{
    internal abstract class BasePage
    {
        protected IWebDriver ChromeDriver { get; set; }

        public BasePage(IWebDriver driver)
        {
            ChromeDriver = driver;
        }
    }
}