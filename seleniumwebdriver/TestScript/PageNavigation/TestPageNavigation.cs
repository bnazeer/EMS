using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
         public void OpenPage()
        {
            //INavigation page= ObjRepository.driver.Navigate();
           // page.GoToUrl(ObjRepository.Config.Getwebsite());
          //  ObjRepository.driver.Navigate().GoToUrl(ObjRepository.Config.Getwebsite());
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            Console.WriteLine("Title of Page {0}", WindowHelper.GetTitle());

        }
    }
}
