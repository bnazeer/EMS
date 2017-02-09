using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.TestScript.Button
{
    [TestClass]
  public class HandleButton
    {
        [TestMethod]
      public void TestButton()
      {
          NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
          TextboxHelper.TypeInTextbox(By.Id("validate-form"), ObjRepository.Config.Getusername());
          TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"), ObjRepository.Config.Getusername());
          //LinkHelper.ClickLink(By.LinkText("Login"));
          Console.WriteLine("Enabled :{0}", ButtonHelper.IsButtonEnabled(By.LinkText("Login")));
          Console.WriteLine("Enabled :{0}", ButtonHelper.GetButtonText(By.LinkText("Login")));
          ButtonHelper.ClickButton(By.LinkText("Login"));

      }
    }
}
