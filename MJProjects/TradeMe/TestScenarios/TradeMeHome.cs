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
using MJProjects.TradeMe.PageObjects;
using OpenQA.Selenium.Support.PageObjects;

namespace MJProjects
{

    [TestFixture]
    public class TradeMeHome
    {
        string objUrl;
    
        IWebDriver objChromeDriver;
        WebDriverWait objWaitForElement;
     

        [SetUp]
            public void TestEntrySetup()
            {
            objUrl = "http://www.trademe.co.nz/";
  
            objChromeDriver = new ChromeDriver();
            objWaitForElement = new WebDriverWait(objChromeDriver, TimeSpan.FromSeconds(10));

            }

            [Test]
            public void TradeMeHomePage()
            {

            objChromeDriver.Manage().Window.Maximize();
            objChromeDriver.Navigate().GoToUrl(objUrl);

            var objTMHomePage = new TMHomePage();
            PageFactory.InitElements(objChromeDriver, objTMHomePage);

            objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(objTMHomePage.strXPathLoginLink)));
            objTMHomePage.LoginLink.Click();

        }

     
        }
}
