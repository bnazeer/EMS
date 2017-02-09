﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    
  public class ButtonHelper
    {
      private static IWebElement element;
        public static void ClickButton(By Locator)
      {
          element = GenericHelper.GetElement(Locator);
          element.Click();
      }
      public static bool IsButtonEnabled(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            return element.Enabled;
      }
      public static string  GetButtonText(By Locator)
      {
            if (element.GetAttribute("value") == null)
                return String.Empty;
            return element.GetAttribute("value");
        }
    }
}
