using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using seleniumwebdriver.Configuration;
using seleniumwebdriver.CustomException;
using seleniumwebdriver.Interfaces;
using seleniumwebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumwebdriver.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static FirefoxProfile GetFirefoxOption()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            profile = manager.GetProfile("default");
            return profile;

        }
        private static ChromeOptions GetChromeOption()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("start-maximized");
            //opt.AddExtension("");
            return opt;
        }
        private static InternetExplorerOptions GetIExplorerOption()
        {
            InternetExplorerOptions optie = new InternetExplorerOptions();
            optie.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            optie.EnsureCleanSession = true;
            //optie.AddAdditionalCapability("start-maximized");
            return optie;
        }
       
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver(GetFirefoxOption());
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOption());
            return driver;
        }
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIExplorerOption());
            return driver;
        }
        private static PhantomJSDriver GetPhantomJSDriver()
        {
            PhantomJSDriver driver = new PhantomJSDriver();
            return driver;
        }
         [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc) //this method will be get executed first
        {
            ObjRepository.Config = new AppConfigReader();


             switch(ObjRepository.Config.Getbrowertype())
             {
                 case BrowserType.Chrome:
                     ObjRepository.driver = GetChromeDriver();
                     break;
                 case BrowserType.Firefox:
                     ObjRepository.driver = GetFirefoxDriver();
                     break;
                 case BrowserType.IExplorer:
                     ObjRepository.driver=GetIEDriver();
                     break;
                 case BrowserType.PhantomJs:
                     ObjRepository.driver = GetPhantomJSDriver();
                     break;
                 default:
                     throw new NoSuitableDriverFound("Driver Not Found:"+ObjRepository.Config.Getbrowertype().ToString());

             }

        }
   [AssemblyCleanup]
        public static void Teardown()
         {
            if(ObjRepository.driver!=null)
            {
                ObjRepository.driver.Close();
                ObjRepository.driver.Quit();
            }
         }
    }
}
