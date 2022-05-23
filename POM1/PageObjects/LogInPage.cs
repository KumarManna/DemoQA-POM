using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using POM1.DataAccess;


namespace POM1.PageObjects
{
    class LogInPage
    {
        readonly IWebDriver driver;
        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement Name { get; set; }

        [FindsBy(How=How.Id,Using= "password")]
        public IWebElement Pass { get; set; }

        [FindsBy(How=How.Id,Using = "login")]
        public IWebElement LogIn { get; set; }

        public void LogIntoApplication(string TestName)
        {
            //Name.SendKeys("aria");
            //Thread.Sleep(200);
            //Pass.SendKeys("@riaLabel2022");
            //Thread.Sleep(200);
            //IJavaScriptExecutor jex = (IJavaScriptExecutor)this.driver;
            //jex.ExecuteScript("window.scrollBy(0,400)");
            //LogIn.Click();
            //Thread.Sleep(5000);
            var UserData = TestDataAccess.GetTestData(TestName);
            Console.WriteLine(UserData.key);
            Name.SendKeys(UserData.username);
            Thread.Sleep(200);
            Pass.SendKeys(UserData.password);
            Thread.Sleep(200);
            IJavaScriptExecutor jex = (IJavaScriptExecutor)this.driver;
            jex.ExecuteScript("window.scrollBy(0,200)");
            LogIn.Click();
            Thread.Sleep(5000);
        }
    }
}
