using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Core.Selenium
{
    public class Browser
    {
        private static Browser instance = null;
        private IWebDriver driver;

        public static Browser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Browser();
                }
                return instance;
            }
        }

        private Browser()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }


       

        public void CloseBrowser()
        {
            driver?.Dispose();
            instance = null;
        }
    }
}
