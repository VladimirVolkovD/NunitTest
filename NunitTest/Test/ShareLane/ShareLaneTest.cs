using Core.Selenium;
using NUnit.Framework;
using NunitTest.Test.SwagLabs;
using OpenQA.Selenium;

namespace NunitTest.Test.ShareLane
{
    [TestFixture]
    internal class ShareLaneTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
           Browser.Instance.Driver.Navigate().GoToUrl("https://sharelane.com/");
        }

        [Test]
        public void CheckNotificationMessage()
        {
            var expectedMessage = $"Action successful\n×";

             Browser.Instance.Driver.FindElement(By.CssSelector(".example a")).Click();
            var flashElement =  Browser.Instance.Driver.FindElement(By.Id("flash"));

            Assert.That(flashElement.Displayed, Is.EqualTo(true));
            Assert.That(flashElement.Enabled, Is.EqualTo(true));
            Assert.That(flashElement.Text, Is.EqualTo("Text"));

             Browser.Instance.Driver.FindElement(By.XPath("//div[@class='form_group']"));
        }

        [Test]
        public void MyFirstCheckBoxTest()
        {
             Browser.Instance.Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var checkBox =  Browser.Instance.Driver.FindElement(By.TagName("input"));
            checkBox.Click();
            var checkedAttribute = checkBox.GetAttribute("checked");

            Assert.IsNotNull(checkedAttribute);
            Assert.IsTrue(checkBox.Selected);

            checkBox.Click();
            Assert.IsFalse(checkBox.Selected);

            // var checkBoxes = Chrome Browser.Instance.Driver.FindElements(By.TagName("input"));
            //List<IWebElement> elements = Chrome Browser.Instance.Driver.FindElements(By.XPath("//tr")).ToList();
            //elements.Select(element => element.GetAttribute("checked").Equals("true"));
            //elements.Any(element => element.GetAttribute("checked").Equals("true"));
            //elements.Where(element => element.Text.Contains("a"));
        }

        [Test]
        public void MyFirstInputTest()
        {
             Browser.Instance.Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

            var input =  Browser.Instance.Driver.FindElement(By.TagName("input"));

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
             Browser.Instance.Driver.Quit();
        }
    }
}
