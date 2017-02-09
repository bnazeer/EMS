using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.HandleDropDown
{
    [TestClass]
    public class DropDownList
    {
        [TestMethod]
        public void DropDown()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            //IWebElement element = ObjRepository.driver.FindElement(By.LinkText(""));
            //Console.WriteLine("Text:{0}", element.Text);//text property is used to retrive the text of element
            //TextboxHelper.TypeInTextbox(By.Id("validate-form"), ObjRepository.Config.Getusername());
            //TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
            //LinkHelper.ClickLink(By.LinkText("Login"));
            //IWebElement element = ObjRepository.driver.FindElement(By.Id("month"));
            //SelectElement select=new SelectElement(element);
            //select.SelectByIndex(2);
            //select.SelectByText("Aug");
            //select.SelectByValue("4");
            //Console.WriteLine("Selected value {0}", select.SelectedOption.Text);
            //IList<IWebElement> list= select.Options;
            //foreach(IWebElement ele in list)
            //{
            //    Console.WriteLine("value:{0},Text: {1}", ele.GetAttribute("value"), ele.Text);
            //}

            ComboBoxHelper.SelectElement(By.Id("month"),2);
            ComboBoxHelper.SelectElement(By.Id("month"), "Aug");

            foreach(string str in ComboBoxHelper.GetAllItem(By.Id( "month")))
            {
                Console.WriteLine("value :{0}", str);
            }


        }
    }
}
