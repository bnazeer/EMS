using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.Textbox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
           //LinkHelper.ClickLink(By.LinkText("Forget password?"));
           //IWebElement ele=ObjRepository.driver.FindElement(By.Id("validate-form"));
           // ele.SendKeys(ObjRepository.Config.Getusername());
           // ele=ObjRepository.driver.FindElement(By.Id("exampleInputPassword1"));
           // ele.SendKeys(ObjRepository.Config.Getpassword());
           // ele=ObjRepository.driver.FindElement(By.Id("validate-form"));
           // ele.Clear();
            TextboxHelper.TypeInTextbox(By.Id("validate-form"),ObjRepository.Config.Getusername());
            TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
            TextboxHelper.ClearTextbox(By.Id("validate-form"));

        }
    }
}
