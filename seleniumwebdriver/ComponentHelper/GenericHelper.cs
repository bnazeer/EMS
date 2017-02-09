using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    [TestClass]
   public class GenericHelper
    {
        [TestMethod]
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjRepository.driver.FindElements(Locator).Count() == 1;
            }
            catch(Exception)
            {
                return false;
            }
           
        }
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjRepository.driver.FindElement(Locator);
            else
                throw new NoSuchElementException("No Element Found" + Locator.ToString());
        }
        public static void TakeScreenShot(string filename="Screen")
        {
            Screenshot screen = ((ITakesScreenshot)ObjRepository.driver).GetScreenshot();
            if(filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MMM-dd-mm-ss") + "jpeg";
                screen.SaveAsFile(filename, ImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(filename, ImageFormat.Jpeg);
        }
             
    }
}
