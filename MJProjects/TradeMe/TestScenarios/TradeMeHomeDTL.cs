using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJProjects.TradeMe.TestScenarios
{
    class TradeMeHomeDTL
    {

        [Test]
        public void TMHomeDTL()
        {
            IWebDriver objChromeDriver = new ChromeDriver();

            objChromeDriver.Url = "http://www.trademe.co.nz/";
            string strTitle = objChromeDriver.Title;

            Console.WriteLine("Title of the page is : " + strTitle);

            string strPageURL = objChromeDriver.Url;

            Console.WriteLine("URL of the page is : " + strPageURL);

            string strPageSource = objChromeDriver.PageSource;

            Console.WriteLine("Page Source of the page is : " + strPageSource);

            objChromeDriver.Quit();
        }
    }
}
