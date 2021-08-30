using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Sum.Page
{
    public class BasePage
    {
        protected IWebDriver Driver;
        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
               
    }
}