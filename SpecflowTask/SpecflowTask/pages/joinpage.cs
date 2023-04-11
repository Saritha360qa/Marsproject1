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
    public class register_page
    {
        public void registeractions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();


            //Lunch Localhost:5000
            driver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(2000);

            //Identify the join button and click on it
            IWebElement joinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
            joinbutton.Click();


            //Identify the name textbox and enter the valid name
            IWebElement nametextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            nametextbox.SendKeys("Saritha");

            //Identify the last name textbox and enter the valid last name
            IWebElement lastnametextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
            lastnametextbox.SendKeys("Muthavarapu");

            //Get Timestamp and generate unique email
            var Timestamp = Stopwatch.GetTimestamp();
            var email = "Saritha" + Timestamp.ToString() + "@a.com";

            //Identify the Emailid textbox and enter the valid Emailid
            IWebElement emailidtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
            emailidtextbox.SendKeys(email);

            //Identify the password textbox and enter the valid password
            IWebElement passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
            passwordtextbox.SendKeys("Test1235");

            //Identify the reenter password textbox and enter the valid password
            IWebElement reenterpasswordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
            reenterpasswordtextbox.SendKeys("Test1235");

            //Click on terms and conditions checkbox
            IWebElement termsandconditionscheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
            termsandconditionscheckbox.Click();
            Thread.Sleep(1000);

            //Click on join button
            IWebElement joinbutton1 = driver.FindElement(By.Id("submit-btn"));
            joinbutton1.Click();
            Thread.Sleep(3000);

            //Check if new user register successfully
            // IWebElement newregister = driver.FindElement(By.XPath("/html/body/div"));
           // Assert.That(newregister.Text! == "unsuccessfull", "not registered successfully");
        }
        public string GetText(IWebDriver driver)
        {
            IWebElement actualText = driver.FindElement(By.XPath("/html/body/div"));
            Console.WriteLine(actualText);
            return actualText.Text;

        }

    }
}
