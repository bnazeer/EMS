using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.CheckBox
{
    [TestClass]
   public class TestCheckBox
    {
        [TestMethod]
        public void CheckedCheckBox()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            TextboxHelper.TypeInTextbox(By.Id("validate-form"), ObjRepository.Config.Getusername());
            TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
            TextboxHelper.ClearTextbox(By.Id("validate-form"));
            //IWebElement ele = ObjRepository.driver.FindElement(By.Id("RememberMe"));
            //ele.Click();
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("RememberMe")));
            CheckBoxHelper.checkedcheckbox(By.Id("RememberMe"));
            Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("RememberMe")));


        }
    }
}
