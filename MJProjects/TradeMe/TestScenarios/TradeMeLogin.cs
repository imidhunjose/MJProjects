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
    public class TradeMeLogin
    {

        string objUserName;
        string objPassword;
        IWebDriver objChromeDriver;
        WebDriverWait objWaitForElement;
        string objUrl;

        [SetUp]
        public void TestEntrySetup()
        {

            
            objUrl = "http://www.trademe.co.nz/";
            objUserName = "i.midhunjose@gmail.com";
            objPassword = "Wonderful@123";
            objChromeDriver = new ChromeDriver();
            objWaitForElement = new WebDriverWait(objChromeDriver, TimeSpan.FromSeconds(10));
        }

        public void TMHomePage()
        {
            
            objChromeDriver.Manage().Window.Maximize();
            objChromeDriver.Navigate().GoToUrl(objUrl);

            var objTMHomePage = new TMHomePage();
            PageFactory.InitElements(objChromeDriver, objTMHomePage);

            //objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.XPath(objTMHomePage.strXPathLoginLink)));
            objTMHomePage.LoginLink.Click();
        }

        [Test]
            public void TradeMeLoginPage()
            {


                TMHomePage();

                string strCurrentUrl = "https://www.trademe.co.nz/Members/Login.aspx";
                objChromeDriver.Navigate().GoToUrl(strCurrentUrl);
                var objTMLoginPage = new TMLoginPage();
                PageFactory.InitElements(objChromeDriver, objTMLoginPage);

                //objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id(objTMLoginPage.strXPathUserName)));
                objTMLoginPage.UserName.SendKeys(objUserName);

                //objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id(objTMLoginPage.strXPathPassword)));
                objTMLoginPage.Password.SendKeys(objPassword);

                //objWaitForElement.Until(ExpectedConditions.ElementIsVisible(By.Id(objTMLoginPage.strXPathLoginButton)));
                objTMLoginPage.LoginButton.Click();

      
            }

       
        }
}
