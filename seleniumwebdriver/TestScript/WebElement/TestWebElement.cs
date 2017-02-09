using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.WebElement
{
    [TestClass]
   public class TestWebElement
    {
    [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            try
            {
                ReadOnlyCollection<IWebElement> Col= ObjRepository.driver.FindElements(By.TagName("input"));
                Console.WriteLine("size:{0}", Col.Count());
                Console.WriteLine("size:{0}", Col.ElementAt(0));
                //find element retune single element on a web page based on matching attribute
                ObjRepository.driver.FindElement(By.TagName("input"));
                ObjRepository.driver.FindElement(By.ClassName("btn btn-primary pull-right"));
                ObjRepository.driver.FindElement(By.CssSelector("#validate-form"));
                ObjRepository.driver.FindElement(By.LinkText("Forget password?"));
                ObjRepository.driver.FindElement(By.PartialLinkText("Forget"));
                ObjRepository.driver.FindElement(By.Name("Username"));
                ObjRepository.driver.FindElement(By.Id("validate-form"));
                ObjRepository.driver.FindElement(By.XPath("//input[@id='find']"));
                ObjRepository.driver.FindElement(By.XPath("//input[@id='find1']"));
                //find elements will retune list of elements in the form of read only collection.readonlycollection means elements will be read only not be modified.
                IList<string> list = new List<string>();//list will have only string type
                list.Add("Task-1");
                list.Add("Task-2");
                list.Add("Task-3");
                Console.WriteLine("size:{0}", list.Count());
                list.Remove("Task-2");
                Console.WriteLine("size:{0}", list.Count());
                Console.WriteLine("size:{0}", list[0]);
                list.Clear();
                Console.WriteLine("size:{0}", list.Count());



            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            ObjRepository.driver.FindElement(By.TagName("input"));
            ObjRepository.driver.FindElement(By.ClassName("btn btn-primary pull-right"));
            ObjRepository.driver.FindElement(By.CssSelector("#validate-form"));
            ObjRepository.driver.FindElement(By.LinkText("Forget password?"));
            ObjRepository.driver.FindElement(By.PartialLinkText("Forget"));
            ObjRepository.driver.FindElement(By.Name("Username"));
            ObjRepository.driver.FindElement(By.Id("validate-form"));
            ObjRepository.driver.FindElement(By.XPath("//input[@id='find']"));

        }
    }
}
