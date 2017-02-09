using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
   public class NavigationHelper
    {
       //this class will take care of all the operation related to navigation
        public static void NavigatetoURL(string url)
       {
           ObjRepository.driver.Navigate().GoToUrl(url);
       }
    }
}
