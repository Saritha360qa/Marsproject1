using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.pages
{
    public class signinpage
    {
        public void loginactions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();


            //Lunch Localhost:5000
            driver.Navigate().GoToUrl("http://localhost:5000/");
            Thread.Sleep(2000);

            //Navigate to signin button and click on it
            IWebElement signinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signinbutton.Click();
            Thread.Sleep(5000);

            //Identify email address textbox and enter the valid email address
            IWebElement emailaddersstextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddersstextbox.Click();
            emailaddersstextbox.SendKeys("saritha@grr2.la");

            //Identify passwordtextbox and enter the valid password
            IWebElement passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordtextbox.SendKeys("Test1235");

            //Click on login button
            IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            Thread.Sleep(2000); 

        }
        public string GetText(IWebDriver driver)
        {
            IWebElement actualText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            return actualText.Text;
        }

    }
}
