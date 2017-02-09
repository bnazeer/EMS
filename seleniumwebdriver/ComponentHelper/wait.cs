using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
   public class wait
    {
       //public static void waitstatment()
       //{
       //    ObjRepository.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
       //}
       public void WaitForElementVisible(IWebDriver driver, By element)
       {
           try
           {
               WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
               wait.Until(ExpectedConditions.ElementIsVisible(element));
           }
           catch (WebDriverTimeoutException)
           {
               //TakeScreenshot(Driver);
               Console.Write("Test failed trying to wait for this element " + element.ToString() + " to be visible ");
           }
       }

       internal static void WaitForElementVisible()
       {
           throw new NotImplementedException();
       }
    }
}
