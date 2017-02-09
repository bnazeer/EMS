using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace seleniumwebdriver.EMS
{
    public class List1
    {
        private IWebDriver driver;
        [FindsBy(How =How.CssSelector,Using = ".wizard-color-primary")][CacheLookup]
        public IWebElement ListM_btn { get; set; }
        [FindsBy(How =How.Id,Using ="listName")][CacheLookup]
        public IWebElement Listname { get; set; }
        [FindsBy(How =How.CssSelector,Using = "button.ng-binding")][CacheLookup]
        public IWebElement Create { get; set; }
        public  void  LoginToApplication()
        {
            ListM_btn.Submit();
            Listname.SendKeys("TestUser_1");
            Create.Submit();
        }
    }
}
