using Core.Models;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;

namespace BussinesObjects
{
    public class LoginSaleForcePage
    {
        
        Input EmailInput = new Input(By.XPath("//input[@name='username']"));
        Input PasswordInput = new Input(By.XPath("//input[@name='pw']"));
        Button LoginButton = new Button(By.XPath("//input[@name='Login']"));
              

        public LoginSaleForcePage OpenPage() 
        {
            Browser.Instance.NavigateToUrl("https://tms4.lightning.force.com/");
            return this;
        }

        public NewAccountModal Login(User user)
        {
            EmailInput.Write(user.Name);
            PasswordInput.Write(user.Password);
            LoginButton.Click();
            Browser.Instance.NavigateToUrl("https://tms4.lightning.force.com/lightning/o/Account/list?filterName=Recent");
            new Button(By.XPath("//div[@title='New']")).Click();
            return new NewAccountModal();
        }
    }
}
