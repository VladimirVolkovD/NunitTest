using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class DropDown : BaseElement
    {
        public DropDown(By locator) : base(locator)
        {
        }

        public DropDown(string locator) : base($"//span[text()='{locator}']/ancestor::div[contains(@class, 'uiInput')]//a")
        {
        }

        public void Select(string option)
        {
            Browser.Driver.FindElement(Locator).Click();
            Browser.Driver.FindElement(By.CssSelector($"a[title='{option}']")).Click();
        }
    }
}
