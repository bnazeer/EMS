using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;

using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumwebdriver.EMS;

namespace seleniumwebdriver.TestScript.Create_List
{
    [TestClass]
  public class CreateList
    {
        [TestMethod]
        public void createlist()
        {
            IWebDriver driver = new FirefoxDriver();
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            List1 listMpage = new List1();
            PageFactory.InitElements(driver, listMpage);
            listMpage.ListM_btn.Submit();
            listMpage.Listname.SendKeys("");
            listMpage.Create.Submit();


            
        }
        
    }
    
}
