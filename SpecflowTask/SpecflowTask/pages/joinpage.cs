using Automation1.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowTask.utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.pages
{
    public static class register_page
    {
        //Finding element by XPath
        private static IWebElement joinbutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
        private static IWebElement nametextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
        private static IWebElement lastnametextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
        private static IWebElement emailidtextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
        private static IWebElement passwordtextbox =>Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
        private static IWebElement reenterpasswordtextbox => Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
        private static IWebElement termsandconditionscheckbox =>Commondriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
        private static IWebElement joinbutton1 => Commondriver.driver.FindElement(By.Id("submit-btn"));
        private static IWebElement confirmationAlert => Commondriver.driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        public static void registeractions()
        {
            Commondriver.driver.Manage().Window.Maximize();
            //Launch MarsQA Website
            Commondriver.driver.Navigate().GoToUrl("http://localhost:5000/");            
        }
        public static void GoTojoinbutton()
        {   
            //Identify the join button and click on it
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/button", 10);
            joinbutton.Click();
        }
        public static void AddName()
        {
            //Identify the name textbox and enter the valid name
            Wait.WaitForELementToExist(Commondriver.driver, "XPath", "/html/body/div[2]/div/div/form/div[1]/input", 10);
            nametextbox.SendKeys("Saritha");
        }
        public static void AddLastName()
        {
           //Identify the last name textbox and enter the valid last name
            lastnametextbox.SendKeys("Muthavarapu");
        }
        public static void AddEmailid()
        {
            //Get Timestamp and generate unique email
            var Timestamp = Stopwatch.GetTimestamp();
            var email = "Saritha" + Timestamp.ToString() + "@a.com";
            //Identify the Emailid textbox and enter the valid Emailid
            emailidtextbox.SendKeys(email);
        }
        public static void AddPassword()
        {
            //Identify the password textbox and enter the valid password
            passwordtextbox.SendKeys("Test1235");
        }
        public static void reenterpassword()
        {
            //Identify the reenter password textbox and enter the valid password
            reenterpasswordtextbox.SendKeys("Test1235");
        }
        public static void Clicktermsandconditions()
        {
            //Click on terms and conditions checkbox
            termsandconditionscheckbox.Click();
        }
        public static void Clickjoinbutton()
        { 
            //Click on join button
            Wait.WaitTobeClickable(Commondriver.driver, "Id", "submit-btn", 7);            
            joinbutton1.Click();
            Wait.WaitForELementToExist(Commondriver.driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div", 3);
        }
        public static string alertWindow()
        {
            Wait.WaitForELementToExist(Commondriver.driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            return confirmationAlert.Text;
        }
        
    }
}
