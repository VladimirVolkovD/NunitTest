using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NunitTest
{
    [TestFixture]
    internal class SeleniumTest
    {
        WebDriver ChromeDriver { get; set; }
        int count = 0;


        [SetUp]
        public void SetUp()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void MyFirstSeleniumTest()
        {
            ChromeDriver.Navigate().GoToUrl("https://sharelane.com/");
        }

        [Test]
        public void MyFirstCheckBoxTest()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var checkBox = ChromeDriver.FindElement(By.TagName("input"));
            checkBox.Click();
            var checkedAttribute = checkBox.GetAttribute("checked");

            SelectElement selectElement = new SelectElement(ChromeDriver.FindElement(By.Id("checkBox")));
            selectElement.SelectByText("Option 1");

            Assert.IsNotNull(checkedAttribute);
            Assert.IsTrue(checkBox.Selected);

            checkBox.Click();
            Assert.IsTrue(checkBox.Selected);

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
