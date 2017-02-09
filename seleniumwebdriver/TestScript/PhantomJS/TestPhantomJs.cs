using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.PhantomJS
{
    [TestClass]
   public class TestPhantomJs
    {
        [TestMethod]
        public void TestPhantomJsDriver()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            GenericHelper.TakeScreenShot();
            ComboBoxHelper.SelectElement(By.Id("month"), 2);
            GenericHelper.TakeScreenShot();
            ComboBoxHelper.SelectElement(By.Id("month"), "Aug");
            GenericHelper.TakeScreenShot();
        }
    }
}
