using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seleniumwebdriver.Settings;
using OpenQA.Selenium;
using Excel= Microsoft.Office.Interop.Excel;
using seleniumwebdriver.ExcelReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace seleniumwebdriver.ComponentHelper
{
   public class PFPordercreation
    {
       private static IWebElement element;
       //private static  IWebElement element1;
       public static  void position1()
       {
           ComboBoxHelper.SelectElement(By.Id("drpApplication"), "ESP");
           ComboBoxHelper.SelectElement(By.Id("drpAdType"), "PFP");
           ComboBoxHelper.SelectElement(By.Id("drpPosition"), "1");
           //element=ObjRepository.driver.FindElement(By.CssSelector("input.ng-valid-editable"));
           //element.SendKeys("Awards");
           //element.Click();

           //ObjRepository.driver.FindElement(By.Name("productInfo")).SendKeys("test_awards");
           //ObjRepository.driver.FindElement(By.Name("impressionPerMonth")).SendKeys("55");
           ////.btn-group > button:nth-child(1)
           //ButtonHelper.ClickButton(By.CssSelector(".btn-group > button:nth-child(1)"));
           List<string> rowValue = new List<string> { };
           //var ExcelFilePath = "C:\\Users\\Kamrul QA\\Desktop\\Selenium Learing\\ReadExcelData\\TestCaseFile\\MyExcelFile.xlsx";
           var ExcelFilePath = "F:/rentvm/Orderlines.xlsx";
           Excel.Application xlApp = new Excel.Application();
           Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
           Excel._Worksheet sheet;
           Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
           sheet = xlWorkbook.Worksheets.get_Item(1);
           Excel.Range xlRange = xlWorksheet.UsedRange;
           Excel.Range range;
           range = sheet.UsedRange;
           int rowCount = xlRange.Rows.Count;
           int colCount = xlRange.Columns.Count;
           

           for ( rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
           {
               string searchterm;
               string productinfo;
               string impression;

               //for (int j = 1; j <= colCount; j++)

               // rowValue.Add(xlRange.Cells[i, j].Value2.ToString());
               Excel.Range myIDBinder = (Excel.Range)sheet.get_Range("A" + rowCount.ToString());
               searchterm = myIDBinder.Value.ToString();
               myIDBinder = (Excel.Range)sheet.get_Range("B" + rowCount.ToString());
               if (myIDBinder.Value == null)
               {
                   productinfo = string.Empty;

               }
               else
               {
                   productinfo = myIDBinder.Value.ToString();
               }
               myIDBinder = (Excel.Range)sheet.get_Range("C" + rowCount.ToString());
               impression = myIDBinder.Value.ToString();
               element=ObjRepository.driver.FindElement(By.CssSelector("input.ng-valid-editable"));
               element.SendKeys(searchterm);
               element.Click();
               TextboxHelper.TypeInTextbox(By.Name("productInfo"),productinfo);
               TextboxHelper.TypeInTextbox(By.Name("impressionPerMonth"),impression);
               ButtonHelper.ClickButton(By.CssSelector(".btn-group > button:nth-child(1)"));
               
     
               //if (expectedrsul == "Invalid login attempt")
               //{
               //    ObjRepository.driver.FindElement(By.Name("Username")).Clear();
               //    ObjRepository.driver.FindElement(By.Id("exampleInputPassword1")).Clear();
               //}
               //if (password == "")
               //{
               //    //var inputpass = driver.FindElement(By.Id("exampleInputPassword1"));
               //    //  expectedrsul = pass.GetAttribute("data-val-required");
               //    //  user.Clear();

               //    //Assert.AreEqual(expectedrsul, password==string.Empty);
               //    // Assert.IsTrue(driver.FindElement(By.TagName("form-control")).Text.Contains(expectedrsul));
               //}

               //else
               //{
               //    Assert.IsTrue(ObjRepository.driver.FindElement(By.TagName("body")).Text.Contains(expectedrsul));
               //}

               //try
               //{

               //    Thread.Sleep(10000);
               //    var profile = ObjRepository.driver.FindElement(By.CssSelector("#top_nav_right_options_container > li:nth-child(6) > a"));
               //    profile.Click();
               //    // #top_nav_right_options_container > li:nth-child(6) > a
               //    Thread.Sleep(10000);
               //    //driver.FindElement(By.Id("logoutForm")).Click();



               //    // driver.FindElement(By.CssSelector("#top_nav_right_options_container > li.dropdown.open > ul > li:nth-child(8) > a")).Click();
               //    ObjRepository.driver.FindElement(By.PartialLinkText("Sign Out")).Click();
               //}
               ////}
               ////// #top_nav_right_options_container > li.dropdown.open > ul > li:nth-child(8) > a

               //catch (Exception ex)
               //{
               //    ////    //
               //}
           }
       }

        public static  void position2()
        {
           ComboBoxHelper.SelectElement(By.Id("drpApplication"), "ESP");
           ComboBoxHelper.SelectElement(By.Id("drpAdType"), "PFP");
           ComboBoxHelper.SelectElement(By.Id("drpPosition"), "2");
           //element=ObjRepository.driver.FindElement(By.CssSelector("input.ng-valid-editable"));
           //element.SendKeys("Awards");
           //element.Click();

           //ObjRepository.driver.FindElement(By.Name("productInfo")).SendKeys("test_awards");
           //ObjRepository.driver.FindElement(By.Name("impressionPerMonth")).SendKeys("55");
           ////.btn-group > button:nth-child(1)
           //ButtonHelper.ClickButton(By.CssSelector(".btn-group > button:nth-child(1)"));
           List<string> rowValue = new List<string> { };
           //var ExcelFilePath = "C:\\Users\\Kamrul QA\\Desktop\\Selenium Learing\\ReadExcelData\\TestCaseFile\\MyExcelFile.xlsx";
           var ExcelFilePath = "F:/rentvm/Orderlines.xlsx";
           Excel.Application xlApp = new Excel.Application();
           Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
           Excel._Worksheet sheet;
           Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
           sheet = xlWorkbook.Worksheets.get_Item(1);
           Excel.Range xlRange = xlWorksheet.UsedRange;
           Excel.Range range;
           range = sheet.UsedRange;
           int rowCount = xlRange.Rows.Count;
           int colCount = xlRange.Columns.Count;


           for (rowCount = 3; rowCount <= range.Rows.Count; rowCount++)
           {
               string searchterm;
               string productinfo;
               string impression;

               //for (int j = 1; j <= colCount; j++)

               // rowValue.Add(xlRange.Cells[i, j].Value2.ToString());
               Excel.Range myIDBinder = (Excel.Range)sheet.get_Range("A" + rowCount.ToString());
               searchterm = myIDBinder.Value.ToString();
               myIDBinder = (Excel.Range)sheet.get_Range("B" + rowCount.ToString());
               if (myIDBinder.Value == null)
               {
                   productinfo = string.Empty;

               }
               else
               {
                   productinfo = myIDBinder.Value.ToString();
               }
               myIDBinder = (Excel.Range)sheet.get_Range("C" + rowCount.ToString());
               impression = myIDBinder.Value.ToString();
               element = ObjRepository.driver.FindElement(By.CssSelector("input.ng-valid-editable"));
               element.SendKeys(searchterm);
               element.Click();
               TextboxHelper.TypeInTextbox(By.Name("productInfo"), productinfo);
               TextboxHelper.TypeInTextbox(By.Name("impressionPerMonth"), impression);
               ButtonHelper.ClickButton(By.XPath("(//button[@type='button'])[5]"));
               LinkHelper.ClickLink(By.LinkText("Save and Copy"));
               if(searchterm==myIDBinder.Value.ToString())
               {
                   Assert.AreEqual(searchterm, myIDBinder.Value.ToString());
               }
               if (productinfo == myIDBinder.Value.ToString())
               {
                   Assert.AreEqual(productinfo, myIDBinder.Value.ToString());
               }
               if (impression == myIDBinder.Value.ToString())
               {
                   Assert.AreEqual(impression, myIDBinder.Value.ToString());
               }
           }

       }
    }
}
