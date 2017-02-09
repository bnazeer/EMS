using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
   public class WindowHelper //this class is used to make a motheds related to brower function
    {
       public static string GetTitle()
       {
           return ObjRepository.driver.Title;
       }
    }
}
