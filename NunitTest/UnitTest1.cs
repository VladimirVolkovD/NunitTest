using NUnit.Framework;
using NunitTest;

namespace NunitTestNameSpace
{
    [TestFixture]
    public class TestsClass
    {
        int randomInt;
        Calculator calculator;

        [OneTimeSetUp]
        public void SetupForClass()
        {
            randomInt = new Random().Next(0, 4);
            calculator = new Calculator();
        }


        [SetUp]
        public void SetupForEachMethods()
        {
            randomInt = new Random().Next(0, 4);
        }



        [Test, Category("Test empty"), Description("Super test")]
        public void Test()
        {

        }

        [Test]
        [TestCase(1,2)]
        [Description("Test")]
        [Category("UnitTest")]
        public void SummTest_addOperand1_addOperand2(
            [Values(1)] int operand1,
            [Random(-1, 100, 7)] int operand2)
        {
            //Action
            var actualResult = calculator.Summ(operand1, operand2);

            //Assert
            Assert.AreEqual(actualResult, actualResult - 1, $"Reults failed");
            Assert.That(2, Is.EqualTo(actualResult), $"Summ {operand1} + {operand2} = {actualResult}");
        }


        [Category("Collection")]
        [Test]
        
        public void TC1_Login_CorrectLogin()
        {
            //Var
            var tooMuchNumber = new[] { 1, 2, 3, 4, 5, 6 };
            var lessNumbers = new[] { 1, 3 };


            //Assert
            CollectionAssert.Contains(lessNumbers, tooMuchNumber);
        }

        [Category("Collection")]
        [Test]

        public void Login_LoginWithIncorrectCredentials_ShowErrorMessage()
        {
            //Var
            var tooMuchNumber = new[] { 1, 2, 3, 4, 5, 6 };
            var lessNumbers = new[] { 1, 3 };
          
            //Assert
            CollectionAssert.Contains(lessNumbers, tooMuchNumber);
        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}