using NUnit.Framework;
using OpenQA.Selenium;
using NunitTest.SwagLabs.Page;

namespace NunitTest.SwagLabs.Test
{
    [TestFixture]
    internal class LoginTests : SwagLabsBaseTests
    {           

        [Test, Category("Positive")]
        public void Login_LoginWithCorrect_Credentialst()
        {
            string username = "standard_user";
            string password = "secret_sauce";
            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            var inventoryPage = LoginPage.Login(username, password);

            Assert.IsTrue(inventoryPage.CheckCartIconPresented());
            Assert.AreEqual(ChromeDriver.Url, expectedUrl);
        }

        [Test, Category("Negative")]
        public void Login_EmptyPasswordNameFieldTest_CheckErrorMessage()
        {
            string username = "standard_user";
            string errorMessage = "Epic sadface: Password is required";

            LoginPage.TryToLogin(username);
            
            var error = ChromeDriver.FindElement(By.XPath("//*[@data-test='error']"));

            Assert.Multiple(() =>
            {
                Assert.AreEqual(error.Text, errorMessage);
                Assert.IsTrue(error.Displayed);
            });
        }

        [Test, Category("Negative")]        
        public void Login_EmptyUserNameFieldTest_CheckErrorMessage()
        {
            string password = "standard_user";
            string errorMessage = "Epic sadface: Username is required";

            LoginPage.TryToLogin(password: password);

            var error = ChromeDriver.FindElement(By.XPath(" //*[@data-test='error']"));

            Assert.Multiple(() =>
            {
                Assert.AreEqual(error.Text, errorMessage);
                Assert.IsTrue(error.Displayed);
            });
        }
    }
}
