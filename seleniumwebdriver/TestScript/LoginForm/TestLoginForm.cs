using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using seleniumwebdriver.ComponentHelper;
using seleniumwebdriver.ExcelReader;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace seleniumwebdriver.TestScript.LoginForm
{
    [TestClass]
   public class TestLoginForm
    {
        [TestMethod]
        public void Loginpage()
        {
            NavigationHelper.NavigatetoURL(ObjRepository.Config.Getwebsite());
            TextboxHelper.TypeInTextbox(By.Id("txtAsiNum"), ObjRepository.Config.GetASINo());
            TextboxHelper.TypeInTextbox(By.Id("txtUserName"),ObjRepository.Config.Getusername());
            TextboxHelper.TypeInTextbox(By.Id("txtPassword"),ObjRepository.Config.Getpassword());
            ButtonHelper.ClickButton(By.CssSelector("input.btn"));
           // ButtonHelper.ClickButton(By.ClassName("btn btn-primary"));
            
            // LinkHelper.ClickLink(By.LinkText("Login"));
            //input.btn
            //TestExcelData.TestReadExcel();

            //Excel.Range range;

            //for (int rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
            //{
            //    string username;
            //    string password;
            //    string expectedrsul;

            //    //for (int j = 1; j <= colCount; j++)

            //    // rowValue.Add(xlRange.Cells[i, j].Value2.ToString());
            //    Excel.Range myIDBinder = (Excel.Range)sheet.get_Range("A" + rowCount.ToString());
            //    username = myIDBinder.Value.ToString();
            //    myIDBinder = (Excel.Range)sheet.get_Range("B" + rowCount.ToString());
            //    if (myIDBinder.Value == null)
            //    {
            //        password = string.Empty;

            //    }
            //    else
            //    {
            //        password = myIDBinder.Value.ToString();
            //    }
            //    myIDBinder = (Excel.Range)sheet.get_Range("C" + rowCount.ToString());
            //    expectedrsul = myIDBinder.Value.ToString();
            //    TextboxHelper.TypeInTextbox(By.Name("Username"),"");
            //    TextboxHelper.TypeInTextbox(By.Id("exampleInputPassword1"),"");
            //    var btn =ObjRepository.driver.FindElement(By.CssSelector("#validate-form > div.panel-footer > div > button"));
            //    btn.Click();
            //    if (expectedrsul == "Invalid login attempt")
            //    {
            //       ObjRepository.driver.FindElement(By.Name("Username")).Clear();
            //       ObjRepository.driver.FindElement(By.Id("exampleInputPassword1")).Clear();
            //    }
            //    if (password == "")
            //    {
            //        //var inputpass = driver.FindElement(By.Id("exampleInputPassword1"));
            //      //  expectedrsul = pass.GetAttribute("data-val-required");
            //      //  user.Clear();

            //        //Assert.AreEqual(expectedrsul, password==string.Empty);
            //        // Assert.IsTrue(driver.FindElement(By.TagName("form-control")).Text.Contains(expectedrsul));
            //    }

            //    else
            //    {
            //        Assert.IsTrue(ObjRepository.driver.FindElement(By.TagName("body")).Text.Contains(expectedrsul));
            //    }

            //    try
            //    {

            //        Thread.Sleep(10000);
            //        var profile =ObjRepository.driver.FindElement(By.CssSelector("#top_nav_right_options_container > li:nth-child(6) > a"));
            //        profile.Click();
            //        // #top_nav_right_options_container > li:nth-child(6) > a
            //        Thread.Sleep(10000);
            //        //driver.FindElement(By.Id("logoutForm")).Click();



            //        // driver.FindElement(By.CssSelector("#top_nav_right_options_container > li.dropdown.open > ul > li:nth-child(8) > a")).Click();
            //        ObjRepository.driver.FindElement(By.PartialLinkText("Sign Out")).Click();
            //    }
            //    //}
            //    //// #top_nav_right_options_container > li.dropdown.open > ul > li:nth-child(8) > a

            //    catch (Exception ex)
            //    {
            //        ////    //
            //    }
            //}



        }
    }
}
