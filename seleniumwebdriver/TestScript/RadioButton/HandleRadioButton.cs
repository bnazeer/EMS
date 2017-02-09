using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.RadioButton
{
    [TestClass]
   public class HandleRadioButton
    {
        [TestMethod]
       public void SelectRadioButton()
       {
           NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
           IWebElement element = ObjRepository.driver.FindElement(By.XPath(""));
           Console.WriteLine("Text:{0}", element.Text);//text property is used to retrive the text of element
           TextboxHelper.TypeInTextbox(By.Id("validate-form"), ObjRepository.Config.Getusername());
           TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
           LinkHelper.ClickLink(By.LinkText("Login"));
           LinkHelper.ClickLink(By.XPath(""));
            //radio button
            //IWebElement element = ObjRepository.driver.FindElement(By.Id("radio"));
            //element.Click();
           Console.WriteLine("Selected {0}" ,RadioButtonHelper.IsRadioButtonSelected(By.Id("radio-off")));
           RadioButtonHelper.ClickRadioButton(By.Id("radio-on"));


       }
    }
}
