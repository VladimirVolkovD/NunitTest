using Core.Selenium;
using OpenQA.Selenium;

namespace NunitTest.Test.ShareLane
{
    internal class NewAccountModal
    {

        public void Сreate(string accountName, string website, string type, string parentAccount)
        {
            new Input("Account Name").write(accountName);
            new Input("Website").write(website);
            new DropDown("Type").select(type);
        }

        public void Save()
        {
            Browser.Instance.Driver.FindElement(By.CssSelector("[title='Save']")).Click();
        }
    }
}
