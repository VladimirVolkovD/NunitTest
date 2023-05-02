using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NunitTest.Page
{
    internal class InventoryPage : BasePage
    {
        By CartIconLocator = By.ClassName("shopping_cart_link");

        public InventoryPage(WebDriver driver) : base(driver)
        {
            Assert.IsTrue(CheckCartIconPresented());
        }

        public bool CheckCartIconPresented()
        {
            return ChromeDriver.FindElement(CartIconLocator).Displayed;
        }
    }
}
