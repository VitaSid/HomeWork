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
        IWebElement resultFromPage => Driver.FindElement(By.Id("displayvalue"));

        public void InsertFirstInput(string firstInput)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstInput);
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

       
    }

    
}
