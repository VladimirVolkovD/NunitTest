using Core.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Test
{
    [TestFixture]
    internal class AlertTests
    {

        [Test]
        public void AlertTest()
        {
            var driver = Browser.Instance.Driver;
            Browser.Instance.NavigateToUrl("http://the-internet.herokuapp.com/context_menu");
            driver.FindElement(By.CssSelector("#hot-spot")).Click();


            Browser.Instance.ContextClickToElement(By.CssSelector("#hot-spot"));

            Browser.Instance.AcceptAlert();

        }
    }
}
