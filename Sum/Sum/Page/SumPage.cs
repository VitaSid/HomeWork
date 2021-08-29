using Sum.Test;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;
using Sum.Page;

namespace Sum.page
{
    class SumPage : BasePage
    {
        public SumPage(IWebDriver webdriver) : base(webdriver) { }
        IWebElement firstInputField => Driver.FindElement(By.Id("sum1"));
        IWebElement secondInputField => Driver.FindElement(By.Id("sum2"));

        internal object Manage()
        {
            throw new NotImplementedException();
        }

        IWebElement resultFromPage => Driver.FindElement(By.Id("displayvalue"));

        internal object FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public void InsertFirstInput(string firstInput)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
        }

        internal void Quit()
        {
            throw new NotImplementedException();
        }

        public void InsertSecondtInput(string secondInput)
        {
            secondInputField.Clear();
            secondInputField.SendKeys(secondInput);
        }

        public void ClickGetTotalButton()
        {
            Driver.FindElement(By.CssSelector("#gettotal > button")).Click();
        }

        public void VerifyResult (string result)
        {
            Assert.AreEqual(result, resultFromPage.Text, $"Actual result differs from expected {result}");
        }

        public static implicit operator SumPage(ChromeDriver v)
        {
            throw new NotImplementedException();
        }
    }

    
}
