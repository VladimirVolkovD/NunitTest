using Core.Models;
using Core.Utilities;
using NUnit.Framework;

namespace NunitTest.Test.SwagLabs
{
    [TestFixture]
    internal class LoginTests : SwagLabsBaseTests
    {
        [Test]
        public void EnvVariablesExample()
        {
            Environment.SetEnvironmentVariable("Test1", "Value1");
            var value = Environment.GetEnvironmentVariable("Test1");

            // Now retrieve it.
            value = Environment.GetEnvironmentVariable("Browser", EnvironmentVariableTarget.Machine);

        }

        [Test, Category("Positive")]
        public void Login_LoginWithCorrect_Credentialst()
        {
            var standartUser = UserBuilder.StandartUser;
            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            var inventoryPage = LoginPage.Login(standartUser);

            Assert.IsTrue(inventoryPage.CheckCartIconPresented());
            Assert.AreEqual(Driver.Url, expectedUrl);
        }

        [Test, Category("Negative")]
        public void Login_EmptyPasswordNameFieldTest_CheckErrorMessage()
        {
            string errorMessage = "Epic sadface: Password is required";
            var user = UserBuilder.GetRandomUser();

            LoginPage.TryToLogin(user);
            var errorText = LoginPage.GetErrorMessage();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(errorText, errorMessage);
            });
        }

        [Test, Category("Negative")]
        public void Login_EmptyUserNameFieldTest_CheckErrorMessage()
        {
            string errorMessage = "Epic sadface: Username is required";

            var user = new User
            {
                Password = "123",
                Name = "",
            };

            LoginPage.TryToLogin(user);
            var errorText = LoginPage.GetErrorMessage();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(errorText, errorMessage);
            });
        }
    }
}
