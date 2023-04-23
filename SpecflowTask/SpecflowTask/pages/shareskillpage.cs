using Automation1.utilities;
using OpenQA.Selenium;
using SpecflowTask.utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTask.pages
{
    public static class shareskillpage
    {
        private static IWebElement shareskillstab =>Commondriver. driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        private static IWebElement titletextbox => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        private static IWebElement descriptiontextbox => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        private static IWebElement categorydropdown => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));
        private static IWebElement musicaudiooption => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[6]"));
        private static IWebElement subcategorydropdown => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
        private static IWebElement voiceoveroption => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[3]"));
        private static IWebElement tagstextbox => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
        private static IWebElement oneoffservicebutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
        private static IWebElement onsitebutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
        private static IWebElement startdate => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
        private static IWebElement enddate => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        private static IWebElement addnewtag => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input"));
        private static IWebElement savebutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
        private static IWebElement createdcategory => Commondriver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
        private static IWebElement createdtitle => Commondriver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
        private static IWebElement createddescription => Commondriver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
        private static IWebElement createdservicetype =>Commondriver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[5]"));
        private static IWebElement createdactive => Commondriver.driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[7]/div/input"));
        public static void ShareSkills()
        {
            //Navigate to shareskills tab
            shareskillstab.Click();
        }
        public static void Entertitlename()
        {
            //Identify title textbox and enter valid title name
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 10);
            titletextbox.SendKeys("music for beginners");
        }
        public static void Enterdescription()
        {
            //Identify description textbox and enter valid description
            descriptiontextbox.SendKeys("my hobbies are listening music");
        }
        public static void Selectcategory()
        {
            //Identify category dropdown ans select category and subcategory
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select", 10);
            categorydropdown.Click();
            musicaudiooption.Click();
        }
        public static void Selectsubcategory()
        {
            //Identify subcategory dropdown select subcategory
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select", 10);
            subcategorydropdown.Click();
            voiceoveroption.Click();
        }
        public static void Addtag()
        {
            //Identify tags textbox and add new tag
            tagstextbox.SendKeys("abc");
            tagstextbox.SendKeys(Keys.Enter);
        }
        public static void Clickoneoffservicebutton()
        {
            //Identify servicetypebutton and click on oneoff service button
            oneoffservicebutton.Click();
            oneoffservicebutton.Click();
        }
        public static void Clickonsitebutton()
        {
            //Identify locetion type and click on onsitebutton
            onsitebutton.Click();
        }
        public static void Enterdates()
        {
            //Identify availabledates textbox and enter start date and end date
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input", 10);
            startdate.SendKeys("08-4-2024");
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 10);
            enddate.SendKeys("05-05-2024");
        }
        public static void Addskillexchangetag()
        {
            //Identify skillexchange tab and add new tags
            addnewtag.SendKeys("def");
            addnewtag.SendKeys(Keys.Enter);
        }
        public static void Clicksavebutton()
        {
            //click on save button            
            savebutton.Click();
            Wait.WaitForELementToExist(Commondriver.driver, "XPath", "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[2]", 10);
        }        
        public static string Getcreatedcategory()
        {            
            return createdcategory.Text;
        }
        public static string Getcreatedtitle()
        {            
            return createdtitle.Text;
        }
        public static string Getcreateddescription()
        {            
            return createddescription.Text;
        }
        public static string Getcreatedservicetype()
        {        
            return createdservicetype.Text;
        }
        public static string Getcreatedactive()
        {            
            return createdactive.Enabled.ToString();
        }
    }
}
