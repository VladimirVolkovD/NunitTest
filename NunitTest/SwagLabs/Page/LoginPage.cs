using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.SwagLabs.Page
{
    internal class LoginPage : BasePage
    {
        By UserNameInputLocator = By.XPath("//*[@data-test='username']");
        By PassrowdInputLocator = By.CssSelector("#password");
        By LoginButtonLocator = By.Name("login-button");

        public LoginPage(WebDriver driver): base(driver) { }      

        void SetUserName(string name)
        {
            ChromeDriver.FindElement(UserNameInputLocator).SendKeys(name);
        }

        void SetPasswrod(string password)
        {
            ChromeDriver.FindElement(PassrowdInputLocator).SendKeys(password);
        }

        void ClickLoginButton()
        {
            ChromeDriver.FindElement(LoginButtonLocator).Click();
        }

        public void TryToLogin(string name = "", string password = "")
        {
            SetUserName(name);
            SetPasswrod(password);
            ClickLoginButton();
        }

        public InventoryPage Login(string name = "", string password = "") 
        {
            TryToLogin(name, password);
            return new InventoryPage(ChromeDriver);
        }
    }
}
