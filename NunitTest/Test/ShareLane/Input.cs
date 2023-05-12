using Core.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test.ShareLane
{
    internal class Input
    {
        String label;

        public Input(string label)
        {
           
            this.label = label;
        }

        public void write(string text)
        {
            Browser.Instance.Driver.FindElement(By.XPath(
                    string.Format("//span[text()='{0}']/ancestor::div[contains(@class, 'uiInput')]//input", label)))
                    .SendKeys(text);
        }
    }
}
