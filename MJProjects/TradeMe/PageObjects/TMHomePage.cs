using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJProjects.TradeMe.PageObjects
{
    class TMHomePage
    {
        public string strXPathLoginLink = "//*[@id='LoginLink']";
        [FindsBy(How = How.Id, Using = "LoginLink")]
        public IWebElement LoginLink { get; set; }          
      
    }
}
