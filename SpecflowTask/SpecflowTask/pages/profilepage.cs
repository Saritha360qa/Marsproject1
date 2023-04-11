using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Memory;
using System.Diagnostics;

namespace SpecflowTask.pages
{
    internal class profilepage
    {
        
        public void AddSkills(IWebDriver driver)
        {
            //Navigate to the skills tab
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();

            //Click on addnew button
            IWebElement addnewbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();

            string skill = "Music3";// + Stopwatch.GetTimestamp().ToString();

            //Identify addskill textbox and enter skill
            IWebElement addskilltextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskilltextbox.SendKeys(skill);
            Thread.Sleep(3000);

            //Select skill level from choose skill level dropdown
            IWebElement skillleveldropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillleveldropdown.Click();
            Thread.Sleep(1000);

            IWebElement expertoption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            expertoption.Click();

            //Click on add button 
            IWebElement addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addbutton.Click();
            Thread.Sleep(1000);

            //Check if new skill has been added 
            //IWebElement newskilladded = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            //Assert.That(newskilladded.Text == "music", "actual code and expected code do not match");
        }

        public string GetaddedText(IWebDriver driver)
        {
            IWebElement actualText = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Console.WriteLine(actualText);
            return actualText.Text;

        }

        public string Getaddskill(IWebDriver driver)
        {
            IWebElement addskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return addskill.Text;

        }
        public string Getaddskilllevel(IWebDriver driver)
        {
            IWebElement addskilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return addskilllevel.Text;

        }



        public void EditSkills(IWebDriver driver)
        {

            //Navigate to the skills tab
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();


            //click on skills edit icon
            IWebElement editicon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editicon.Click();
            Thread.Sleep(2000);

            //edit new skill into the skill textbox
            IWebElement editnewskill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editnewskill.Click();
            editnewskill.Clear();
            Thread.Sleep(2000);
            editnewskill.SendKeys("chess2");

            //edit new skill level into the skill level dropdown
            IWebElement skillleveldropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            skillleveldropdown.Click();
            Thread.Sleep(3000);

            IWebElement beginneroption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            beginneroption.Click();

            //click on update button
            IWebElement updatebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updatebutton.Click();
            Thread.Sleep(2000);

        }
        public string GetEditSkill(IWebDriver driver)
        {
            IWebElement CreatedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return CreatedSkill.Text;

        }
        public string GetEditSkilllevel(IWebDriver driver)
        {
            IWebElement CreatedSkilllevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return CreatedSkilllevel.Text;

        }
        public void DeleteSkills(IWebDriver driver)
        {
            //Navigate to the skills tab
            IWebElement skillstab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillstab.Click();

            //click on skills delete button
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deletebutton.Click();
            Thread.Sleep(2000);

        }

            public string GetText(IWebDriver driver)
            {
                IWebElement actualText = driver.FindElement(By.XPath("/html/body/div[1]/div"));
                Console.WriteLine(actualText);
                return actualText.Text;

            }





        }
    }