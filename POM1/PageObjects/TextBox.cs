using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace POM1.PageObjects
{
    class TextBox
    {
        readonly IWebDriver driver;
        public TextBox(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "userName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "userEmail")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "currentAddress")]
        public IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.Id, Using = "permanentAddress")]
        public IWebElement PermanentAddress { get; set; }

       [FindsBy(How =How.Id,Using ="submit")]
       public IWebElement Submit { get; set; }
        
        public void Sign_Up()
        {
            FirstName.SendKeys("ABC");
            Thread.Sleep(200);
            Email.SendKeys("De@gmail.com");
            Thread.Sleep(200);
            IJavaScriptExecutor jex = (IJavaScriptExecutor)driver;
            
            CurrentAddress.SendKeys("Earth");
            Thread.Sleep(200);
            PermanentAddress.SendKeys("Universe");
            Thread.Sleep(200);
            jex.ExecuteScript("window.scrollBy(0,400)");
            Submit.Click();
            Thread.Sleep(5000);
        }
    }
}
