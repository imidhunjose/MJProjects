using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJProjects.TradeMe.PageObjects
{
    class TMPropertySearchPage
    {

        public string strXPathLoginButton = "//*[@id='SearchTabs1_PropertyAnchor']/a";
        [FindsBy(How = How.Id, Using = "SearchTabs1_PropertyAnchor")]
        public IWebElement Login { get; set; }
    }
}
