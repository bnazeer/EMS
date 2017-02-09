using seleniumwebdriver.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.Interfaces
{
   public interface IConfig
    {
       BrowserType Getbrowertype();
       string Getusername();
       string Getpassword();
       string Getwebsite();
       string GetASINo();
        string Getallordersurl();
        string Getsupplierid();

    }
}
