using Automation1.utilities;
using OpenQA.Selenium;
using SpecflowTask.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.pages
{
    public static class signinpage
    {
        private static IWebElement signinbutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private static IWebElement emailaddersstextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private static IWebElement passwordtextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private static IWebElement loginbutton => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        private static IWebElement confirmationAlert => Commondriver.driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        public static void loginactions()
        {
            Commondriver.driver.Manage().Window.Maximize();
            //Launch MarsQA Website
            Commondriver.driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        public static void Clicksigninbutton()
        {
            //Navigate to signin button and click on it
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 10);
            signinbutton.Click();
        }
        public static void Addemailaddress()
        {
            //Identify email address textbox and enter the valid email address
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 10);
            emailaddersstextbox.Click();
            emailaddersstextbox.SendKeys("saritha@grr2.la");
        }
        public static void Addpassword()
        {
            //Identify passwordtextbox and enter the valid password
            passwordtextbox.SendKeys("Test1235");
        }
        public static void Clickloginbutton()
        { 
            //Click on login button            
            loginbutton.Click();
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);
        }        
        public static string alertWindow()
        {            
            return confirmationAlert.Text;
        }

    }
}
