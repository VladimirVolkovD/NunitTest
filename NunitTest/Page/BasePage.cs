using Core.Selenium;
using OpenQA.Selenium;

namespace NunitTest.Page
{
    internal abstract class BasePage
    {
        protected IWebDriver ChromeDriver { get; set; }

        public BasePage()
        {
            ChromeDriver = Browser.Instance.Driver;
        }
    }
}