using seleniumwebdriver.Interfaces;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.Configuration
{
    public class AppConfigReader:IConfig //this class is used to read data from app setting
    {
        public BrowserType Getbrowertype()
        {
            //throw new NotImplementedException();
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType) Enum.Parse(typeof(BrowserType),browser);
        }
        public string GetASINo()
        {
            // throw new NotImplementedException();

            return ConfigurationManager.AppSettings.Get(AppConfigKeys.ASINum);
        }
        public string Getusername()
        {
            //throw new NotImplementedException();
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string Getpassword()
        {
            //throw new NotImplementedException();
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }


        public string Getwebsite()
        {
           // throw new NotImplementedException();

            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
        public string Getallordersurl()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Websiteorder);
        }
        public string Getsupplierid()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.supplierid);
        }
    }
}
