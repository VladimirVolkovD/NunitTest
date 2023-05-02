﻿using OpenQA.Selenium;

namespace NunitTest.Page
{
    internal abstract class BasePage
    {
        protected WebDriver ChromeDriver { get; set; }

        public BasePage(WebDriver driver)
        {
            ChromeDriver = driver;
        }
    }
}