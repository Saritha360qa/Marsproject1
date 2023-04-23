using Automation1.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Memory;
using SpecflowTask.utilities;
using System.Diagnostics;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow.CommonModels;

namespace SpecflowTask.pages
{
    public static class profilepage 
    {
        private static IWebElement Skillstab => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement addnewbutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addskilltextbox => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement skillleveldropdown => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement expertoption => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
        private static IWebElement addbutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement confirmationAlert => Commondriver.driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
        private static IWebElement editicon => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private static IWebElement editnewskill => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
        private static IWebElement skillleveldropdown1 => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
        private static IWebElement beginneroption => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private static IWebElement updatebutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        private static IWebElement deletebutton => Commondriver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));

        public static void AddSkills()
        {
            //Navigate to the skills tab
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 10);            
            Skillstab.Click();
        }
        public static void Clickaddnewbutton()
        {
            //Click on addnew button
            addnewbutton.Click();
        }
        public static void Addskill()
        {
            //Identify addskill textbox and enter skill
            addskilltextbox.SendKeys("Music20");
        }
        public static void Addskilllevel()
        {
            //Select skill level from choose skill level dropdown
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 10);
            skillleveldropdown.Click();
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]", 10);
            expertoption.Click();
        }
        public static void Clickaddbutton()
        { 
            //Click on add button             
            addbutton.Click();
        }
        public static void EditSkills()
        {
            //Navigate to the skills tab
            Skillstab.Click();
        }
        public static void Skilledit()
        {
            //click on skills edit icon
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 10);            
            editicon.Click();
        }
        public static void Editskill()
        {
            //edit new skill into the skill textbox            
            editnewskill.Click();
            editnewskill.Clear();
            editnewskill.SendKeys("chess4");
        }
        public static void Editskilllevel()
        {
            //edit new skill level into the skill level dropdown
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select", 10);            
            skillleveldropdown1.Click();
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]", 10);            
            beginneroption.Click();
        }
        public static void Updatebutton()
        {
            //click on update button            
            updatebutton.Click();
        }
        public static void DeleteSkills()
        {
            //Navigate to the skills tab
            Skillstab.Click();
        }
        public static void Skilldelete()
        { 
            //click on skills delete button
            Wait.WaitTobeClickable(Commondriver.driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 10);            
            deletebutton.Click();
        }
        public static string alertWindow()
        {
            Wait.WaitForELementToExist(Commondriver.driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);            
            return confirmationAlert.Text;
        }
    }

}