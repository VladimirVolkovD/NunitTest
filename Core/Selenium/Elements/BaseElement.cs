using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class BaseElement
    {
        protected Browser Browser => Browser.Instance;
        protected By Locator { get; }

        public BaseElement(By locator)
        {
            Locator = locator;
        }

        public BaseElement(string locator)
        {
            Locator = By.XPath(locator);
        }

        public void Write(string message)
        {
            Browser.Driver.FindElement(Locator).SendKeys(message);
        }

        public void Click()
        {
            Browser.Driver.FindElement(Locator).Click();
        }
    }
}
