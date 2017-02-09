using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace seleniumwebdriver.TestScript.ScreenShoot
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
           // TextboxHelper.TypeInTextbox(By.Id("validate-form"), ObjRepository.Config.Getusername());
           //TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
           //LinkHelper.ClickLink(By.LinkText("Login"));
           //Screenshot screen = ObjRepository.driver.TakeScreenshot();
           // screen.SaveAsFile("screen.jpeg", ImageFormat.Jpeg);
           GenericHelper.TakeScreenShot();
           GenericHelper.TakeScreenShot("Test.Jpeg");
            
        }
    }
}
