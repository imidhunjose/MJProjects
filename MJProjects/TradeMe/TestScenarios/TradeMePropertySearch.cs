using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace MJProjects
{

    [TestFixture]
    public class TradeMePropertySearch
    {
            IWebDriver objChrome;
            string objHomeurl;
            string objUserName;
            string objPassword;
            WebDriverWait objWaitForElement;

            [SetUp]
            public void TestEntrySetup()
            {
                objChrome = new ChromeDriver();
                objHomeurl = "http://www.trademe.co.nz/";
                objUserName = "i.midhunjose@gmail.com";
                objPassword = "Wonderful@123";
                objWaitForElement = new WebDriverWait(objChrome, TimeSpan.FromSeconds(15));

            }

            [Test]
            public void TradeMePropertySearchPage()
            {
                objChrome.Manage().Window.Maximize();
                objChrome.Navigate().GoToUrl(objHomeurl);

                objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='LoginLink']")));
                objChrome.FindElement(By.XPath("//*[@id='LoginLink']")).Click();

                objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id("page_email")));
                objChrome.FindElement(By.Id("page_email")).SendKeys(objUserName);
                objChrome.FindElement(By.XPath("//*[@id='page_password']")).SendKeys(objPassword);
                objChrome.FindElement(By.XPath("//*[@id='LoginPageButton']")).Click();

                objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='SearchTabs1_PropertyAnchor']/a")));
                objChrome.FindElement(By.XPath("//*[@id='SearchTabs1_PropertyAnchor']/a")).Click();

                objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='PropertySearch']/div[4]/div[2]/button")));
                objChrome.FindElement(By.XPath("//*[@id='PropertySearch']/div[4]/div[2]/button")).Click();
              
            }

            [TearDown]
            public void TestExitSetup()
            {
                //objChrome.Quit();
            }
        }
}
