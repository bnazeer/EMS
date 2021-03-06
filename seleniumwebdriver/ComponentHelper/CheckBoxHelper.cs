﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement element;
        public static void checkedcheckbox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }
        public static bool IsCheckBoxChecked(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            string flag = element.GetAttribute("value");
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("true");

        }
    }
}
