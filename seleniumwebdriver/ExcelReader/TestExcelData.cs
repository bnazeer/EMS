
//using Microsoft.Office.Interop.Excel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

//using excel= Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;


namespace seleniumwebdriver.ExcelReader
{
    
   public class TestExcelData
    {
        
        public static void TestReadExcel()
        {
            
            //FileStream stream =new FileStream(@"D/user/", FileMode.Open, FileAccess.Read);
            //IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(stream);
           
            //DataTable table = reader.AsDataSet().Tables["abc"];
            //for(int i=0;i<table.Rows.Count;i++)
            //{
            //    var col = table.Rows[i];
            //    for(int j=0;j<col.ItemArray.Length;j++)
            //    {
            //        Console.WriteLine("Data:{0}", col.ItemArray[j]);

            //    }
            //    Console.WriteLine();
            //}

            List<string> rowValue = new List<string> { };
            //var ExcelFilePath = "C:\\Users\\Kamrul QA\\Desktop\\Selenium Learing\\ReadExcelData\\TestCaseFile\\MyExcelFile.xlsx";
            var ExcelFilePath = "D:/rentvm/dec/users4.xlsx";
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




        }


       
    }
}
