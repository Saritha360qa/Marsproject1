using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.pages
{
    internal class shareskillpage
    {
        public void ShareSkills(IWebDriver driver)
        {
            //Navigate to shareskills tab
            IWebElement shareskillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            shareskillstab.Click();
            Thread.Sleep(3000);

            //Identify title textbox and enter valid title name
            IWebElement titletextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titletextbox.SendKeys("music for beginners");
            Thread.Sleep(1000);

            //Identify description textbox and enter valid description
            IWebElement descriptiontextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptiontextbox.SendKeys("my hobbies are listening music");
            Thread.Sleep(2000);

            //Identify category dropdown ans select category and subcategory
            IWebElement categorydropdown = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categorydropdown.Click();
            Thread.Sleep(2000);

            IWebElement musicaudiooption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[6]"));
            musicaudiooption.Click();

            //Identify subcategory dropdown select subcategory
            IWebElement subcategorydropdown = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcategorydropdown.Click();
            Thread.Sleep(2000);

            IWebElement voiceoveroption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
            voiceoveroption.Click();

            //Identify tags textbox and add new tag
            IWebElement tagstextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            tagstextbox.SendKeys("abc");
            tagstextbox.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //Identify servicetypebutton and click on oneoff service button
            IWebElement oneoffservicebutton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            oneoffservicebutton.Click();

            //Identify locetion type and click on onsitebutton
            IWebElement onsitebutton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            onsitebutton.Click();

            //Identify availabledates textbox and enter start date and end date
            IWebElement startdate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startdate.SendKeys("08-4-2024");
            Thread.Sleep(1000);

            IWebElement enddate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            enddate.SendKeys("05-05-2024");
            Thread.Sleep(1000);

            //Identify skillexchange tab and add new tags
            IWebElement addnewtag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input"));
            addnewtag.SendKeys("def");
            addnewtag.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            //click on save button
            IWebElement savebutton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            savebutton.Click();
            Thread.Sleep(2000);

        }

        public string Getcreatedcategory(IWebDriver driver)
        {
            IWebElement createdcategory = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
            return createdcategory.Text;
        }
        public string Getcreatedtitle(IWebDriver driver)
        {
            IWebElement createdtitle = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
            return createdtitle.Text;
        }
        public string Getcreateddescription(IWebDriver driver)
        {
            IWebElement createddescription = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
            return createddescription.Text;
        }
        public string Getcreatedservicetype(IWebDriver driver)
        {
            IWebElement createdservicetype = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[5]"));
            return createdservicetype.Text;
        }
        public string Getcreatedactive(IWebDriver driver)
        {
           
            IWebElement createdactive = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[7]/div/input"));
            return createdactive.Enabled.ToString();

        }
    }
}
