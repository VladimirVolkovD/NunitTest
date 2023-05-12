using Core.Selenium.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects
{
    public class NewAccountModal
    {
        Input accountName = new Input("Account Name");
        Input website = new Input("Website");
        DropDown typeDropDown = new DropDown("Type");

        Button save = new Button(By.XPath("//button[@title='Save']"));

        public void CreateAccount(string accountName, string websiteName, string option)
        {
            this.accountName.Write(accountName);
            website.Write(websiteName);
            typeDropDown.Select(option);
            save.Click();

        }
    }
}
