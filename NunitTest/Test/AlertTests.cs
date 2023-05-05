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

            Browser.Instance.ContextClickToElement(By.Id("hot-spot"));

            Browser.Instance.AcceptAlert();

            var isLoaded = Browser.Instance.ExecuteScript("return document['readyState'] ? 'complete' == document.readyState : true");


        }


        [Test]
        public void FrameTest()
        {
            var driver = Browser.Instance.Driver;
            driver.SwitchTo().Frame(2);

            driver.FindElement(By.Id(""));
            driver.FindElement(By.Id("")).SendKeys("asd");
            driver.FindElement(By.Id("")).Clear();

            driver.SwitchTo().DefaultContent();



        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.CloseBrowser();
        }
    }
}
