using NUnit.Framework;
using POM1.Wrapper_Factory;
using POM1.PageObjects;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace POM1.TestCases
{
    [TestFixture]
    public class LogInTest:BrowserFactory
    {
        [Test]
       public void Test1()
        {
            BrowserFactory.initBrowser("Firefox");
            BrowserFactory.loadApplication(ConfigurationManager.AppSettings["URL1"]);
            var Login = new LogInPage(driver);

            Login.LogIntoApplication("LogIn");
        }
    }
}
