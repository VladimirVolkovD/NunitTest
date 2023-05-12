using Core.Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test.ShareLane
{
    internal class DropDown
    {
      
        string label;

        public DropDown(string label)
        {
            this.label = label;
        }

        public void select(string option)
        {
            Browser.Instance.Driver.FindElement(By.XPath(
                            string.Format("//span[text()='{0}']/ancestor::div[contains(@class, 'uiInput')]//a", label)
            )).Click();

            Browser.Instance.Driver.FindElement(By.CssSelector(string.Format("a[title='{0}']", option))).Click();
        }
    }
}
