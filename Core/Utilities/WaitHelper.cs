using Core.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class WaitUtilities
    {
        private WebDriverWait waitHelper = new WebDriverWait(Browser.Instance.Driver, TimeSpan);

        public static bool IsPresented()
        {

        }
    }
}
