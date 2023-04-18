using NUnit.Framework;
using NunitTest.SwagLabs.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NunitTest
{
    [TestFixture]
    internal class ShareLaneTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/");
        }
           
        [Test]
        public void CheckNotificationMessage()
        {
            var expectedMessage = $"Action successful\n×";

            ChromeDriver.FindElement(By.CssSelector(".example a")).Click();
            var flashElement = ChromeDriver.FindElement(By.Id("flash")); 

            Assert.That(flashElement.Displayed, Is.EqualTo(true));
            Assert.That(flashElement.Enabled, Is.EqualTo(true));
            Assert.That(flashElement.Text, Is.EqualTo("Text"));

            ChromeDriver.FindElement(By.XPath("//div[@class='form_group']"));
        }

        [Test]
        public void MyFirstCheckBoxTest()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var checkBox = ChromeDriver.FindElement(By.TagName("input"));
            checkBox.Click();
            var checkedAttribute = checkBox.GetAttribute("checked");

            Assert.IsNotNull(checkedAttribute);
            Assert.IsTrue(checkBox.Selected);

            checkBox.Click();
            Assert.IsFalse(checkBox.Selected);

            // var checkBoxes = ChromeDriver.FindElements(By.TagName("input"));
            //List<IWebElement> elements = ChromeDriver.FindElements(By.XPath("//tr")).ToList();
            //elements.Select(element => element.GetAttribute("checked").Equals("true"));
            //elements.Any(element => element.GetAttribute("checked").Equals("true"));
            //elements.Where(element => element.Text.Contains("a"));
        }

        [Test]
        public void MyFirstInputTest()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

            var input = ChromeDriver.FindElement(By.TagName("input"));

            input.SendKeys("123");

            input.Clear();
            input.SendKeys(Keys.Enter);

            input.Clear();
            input.Click();
            input.SendKeys("321");
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
