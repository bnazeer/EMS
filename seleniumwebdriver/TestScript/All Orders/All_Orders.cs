using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using seleniumwebdriver.TestScript.LoginForm;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace seleniumwebdriver.TestScript.All_Orders
{
    [TestClass]
   public class All_Orders
    {
        private static IWebElement element;
        private static IWebElement element1;
        [TestMethod]
        public void allorders()
        {
            
            
                Login.Loginpage();
                //Thread.Sleep(15000);
                ButtonHelper.ClickButton(By.CssSelector(".btn"));

                //    NavigationHelper.NavigatetoURL(ObjRepository.Config.Getallordersurl());
               // ComboBoxHelper.SelectElement(By.Id("drpYear"), "2016");
                //wait.WaitForElementVisible();
                element = ObjRepository.driver.FindElement(By.XPath("//input[contains(@type,'text')]"));
                element.SendKeys("88660");
                element1 = ObjRepository.driver.FindElement(By.XPath("//td[2]"));
                element1.Click();

                //ButtonHelper.ClickButton(By.XPath("//button[contains(@type,'button')][13]"));
                //  wait.WaitForElementVisible();
                NavigationHelper.NavigatetoURL(ObjRepository.Config.Getallordersurl());
                PFPordercreation.position1();

            
            //catch (Exception ex)
            //{

            //    throw;
            //}
         

        }
        [TestMethod]
        public void PFPsaveandcopy()
        {
            Login.Loginpage();
            //Thread.Sleep(15000);
            ButtonHelper.ClickButton(By.CssSelector(".btn"));

            //    NavigationHelper.NavigatetoURL(ObjRepository.Config.Getallordersurl());
            ComboBoxHelper.SelectElement(By.Id("drpYear"), "2016");
            //wait.WaitForElementVisible();
            element = ObjRepository.driver.FindElement(By.XPath("//input[contains(@type,'text')]"));
            element.SendKeys("62660");
            element1 = ObjRepository.driver.FindElement(By.XPath("//td[2]"));
            element1.Click();
            //ButtonHelper.ClickButton(By.XPath("//button[contains(@type,'button')][13]"));
            //  wait.WaitForElementVisible();
            ButtonHelper.ClickButton(By.XPath("(//button[@type='button'])[13]"));
            LinkHelper.ClickLink(By.LinkText("PFP"));
            PFPordercreation.position2();
            
        }
    }
}
