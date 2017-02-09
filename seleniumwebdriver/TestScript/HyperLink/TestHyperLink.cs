using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void clicklink()
        {
           NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
           //IWebElement element= ObjRepository.driver.FindElement(By.LinkText("Forget password?"));
           //element.Click();
           //IWebElement pelement = ObjRepository.driver.FindElement(By.PartialLinkText("Forget"));
           //pelement.Click();
           LinkHelper.ClickLink(By.LinkText("Forget password?"));
           LinkHelper.ClickLink(By.PartialLinkText("Forget"));
        }

    }
}
