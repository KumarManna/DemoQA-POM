using NUnit.Framework;
using POM1.PageObjects;
using BrowserControl;
using System.Configuration;


namespace POM1
{
    public class Tests : Browser
    {
        public void Open_LogInPage()
        {
            Open_Url(ConfigurationManager.AppSettings["URL1"]);
        }

        [Test, Category("Log in page")]
        public void Test1()
        {
            var L = new LogInPage(this.driver);
            Open_LogInPage();
            L.LogIntoApplication("LogIn");
            Assert.Pass();
        }

        public void Open_TextBoxPage()
        {
            Open_Url(ConfigurationManager.AppSettings["URL2"]);
        }
        [Test, Category("TextBox")]
        public void Test2()
        {
            Open_TextBoxPage();
            var T = new TextBox(this.driver);
            T.Sign_Up();
            Assert.Pass();
        }
        [Test, Category("TextBox")]
        public void Test3()
        {
            Open_TextBoxPage();
            var T = new TextBox(this.driver);
            T.FirstName.SendKeys("Abhijit");
            T.Email.SendKeys("zxyz@vip.com");
            T.CurrentAddress.SendKeys("WestBengal");
            T.PermanentAddress.SendKeys("India");
            Scroll();
            Move(T.Submit);
            //T.Submit.Click();
            Assert.Pass();
        }
        [OneTimeTearDown]
        public void End()
        {
            Close_quit();
        }
    }
}