using Core.Selenium;
using NUnit.Framework;
using NunitTest.Test.SwagLabs;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NunitTest.Test.ShareLane
{
    [TestFixture]
    internal class ShareLaneTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            WebDriverWait wait;
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));


        
        }

        [Test]
        public void CheckNotificationMessage()
        {
            var expectedMessage = $"Action successful\n×";

            Driver.FindElement(By.CssSelector(".example a")).Click();
            var flashElement = Driver.FindElement(By.Id("flash"));

            Assert.That(flashElement.Displayed, Is.EqualTo(true));
            Assert.That(flashElement.Enabled, Is.EqualTo(true));
            Assert.That(flashElement.Text, Is.EqualTo("Text"));

            Driver.FindElement(By.XPath("//div[@class='form_group']"));
        }

        [Test]
        public void MyFirstCheckBoxTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var checkBox = Driver.FindElement(By.TagName("input"));
            checkBox.Click();
            var checkedAttribute = checkBox.GetAttribute("checked");

            Assert.IsNotNull(checkedAttribute);
            Assert.IsTrue(checkBox.Selected);

            checkBox.Click();
            Assert.IsFalse(checkBox.Selected);

            // var checkBoxes = Driver.FindElements(By.TagName("input"));
            //List<IWebElement> elements = Driver.FindElements(By.XPath("//tr")).ToList();
            //elements.Select(element => element.GetAttribute("checked").Equals("true"));
            //elements.Any(element => element.GetAttribute("checked").Equals("true"));
            //elements.Where(element => element.Text.Contains("a"));
        }

        [Test]
        public void MyFirstInputTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

            var input = Driver.FindElement(By.TagName("input"));

            input.SendKeys("123");

            input.Clear();
            input.SendKeys(Keys.Enter);

            input.Clear();
            input.Click();
            input.SendKeys("321");
        }

        [Test]
        public void Alert1()
        {
            Driver.Navigate().GoToUrl("https://tms4.my.salesforce.com/");
            Driver.FindElement(By.Id("username")).SendKeys("vladimirwolkov-zgtj@force.com");
            Driver.FindElement(By.Id("password")).SendKeys("QeeTwXGTVcXw72@");
            Driver.FindElement(By.Id("Login")).Click();

            Driver.Navigate().GoToUrl("https://tms4.my.salesforce.com/lightning/o/Account/list?filterName=Recent");
            Driver.FindElement(By.CssSelector("a[title=New]")).Click();

            NewAccountModal newAccountModal = new NewAccountModal();

            newAccountModal.create("Volodya_new", "teachmeskills.by", "Press", "Volodya_new");
            newAccountModal.Save();
        }

        [Test]
        public void Alert2()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");

            Actions a = new Actions(Driver);
            a.MoveToElement(Driver.FindElement(By.CssSelector("#hot-spot"))).ContextClick().Build().Perform();
            Driver.SwitchTo().Alert().Accept();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
