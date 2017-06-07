using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJProjects.TradeMe.PageObjects
{
    class TMLoginPage
    {

        public string strXPathUserName = "//*[@id='page_email']";
        [FindsBy(How = How.Id, Using = "page_email")]
        public IWebElement UserName { get; set; }

        public string strXPathPassword = "//*[@id='page_password']";
        [FindsBy(How = How.Id, Using = "page_password")]
        public IWebElement Password { get; set; }

        public string strXPathLoginButton = "//*[@id='LoginPageButton']";
        [FindsBy(How = How.Id, Using = "LoginPageButton")]
        public IWebElement LoginButton { get; set; }
    }
}
