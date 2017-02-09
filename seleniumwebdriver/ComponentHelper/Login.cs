using OpenQA.Selenium;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    public class Login
    {
        public static void Loginpage()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            TextboxHelper.TypeInTextbox(By.Id("txtAsiNum"), ObjRepository.Config.GetASINo());
            TextboxHelper.TypeInTextbox(By.Id("txtUserName"), ObjRepository.Config.Getusername());
            TextboxHelper.TypeInTextbox(By.Id("txtPassword"), ObjRepository.Config.Getpassword());
            ButtonHelper.ClickButton(By.CssSelector("input.btn"));
            
        }
    }
}
