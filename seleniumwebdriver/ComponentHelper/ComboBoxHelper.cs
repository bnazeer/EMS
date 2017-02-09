using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement Select;
        public static void SelectElement(By Locator,int index)
        {
            Select=new SelectElement(GenericHelper.GetElement(Locator));
            Select.SelectByIndex(index);
        }
        public static void SelectElement(By Locator,string visibletext)
        {
            Select = new SelectElement(GenericHelper.GetElement(Locator));
            Select.SelectByText(visibletext);
        }
        public static IList<string> GetAllItem(By Locator)
        {
            Select = new SelectElement(GenericHelper.GetElement(Locator));
            return Select.Options.Select((x) => x.Text).ToList();
        }

    }
}
