using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Sum.page;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;


namespace Sum.Test
{
    class SumTest
    {
        private static SumPage Driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";
            Driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(_Driver => Driver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            Driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 plus 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 plus 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a plus b = NaN")]
        public static void TestSumCalculation(string firstInput, string secondInput, string result)
        {

            Driver.InsertFirstInput(firstInput);
            Driver.InsertSecondtInput(secondInput);
            Driver.ClickGetTotalButton();
            Driver.VerifyResult(result);

        }


    }
}
