using OpenQA.Selenium;
using seleniumwebdriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.Settings
{
    public class ObjRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver driver { get; set; }
    }
}
