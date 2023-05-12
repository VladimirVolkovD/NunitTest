

using BussinesObjects;
using Core.Models;
using NUnit.Framework;

namespace NunitTest.Test
{
    public class SaleForce
    {
        [Test]
        public void Test()
        {
            var user = new User
            {
                Name = "vladimirwolkov-zgtj@force.com",
                Password = "QeeTwXGTVcXw72@"
            };

            new LoginSaleForcePage()
                 .OpenPage()
                 .Login(user)
                 .CreateAccount(user.Name, user.Password, "Press");
        }
    }
}
