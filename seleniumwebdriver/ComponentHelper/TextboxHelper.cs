using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    public class TextboxHelper
    {
        private static IWebElement element;
        public static void TypeInTextbox(By Locator,string text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(text); 
        }
        public static void ClearTextbox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Clear();
        }
    }
}
