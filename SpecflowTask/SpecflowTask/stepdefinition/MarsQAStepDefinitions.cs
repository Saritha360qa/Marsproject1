using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowTask.pages;
using SpecflowTask.utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTask.stepdefinition
{
    [Binding]
    public class MarsQAWebsiteStepDefinitions:Commondriver
    {
        [Given(@"I registered in MarsQA Website")]
        public void GivenIRegisteredMarsQAWebsiteSucessfully()
        {
            //Registerpage and difinition
            register_page.registeractions();
            register_page.GoTojoinbutton();
            register_page.AddName();
            register_page.AddLastName();
            register_page.AddEmailid();
            register_page.AddPassword();
            register_page.reenterpassword();
            register_page.Clicktermsandconditions();
            register_page.Clickjoinbutton();
        }
        [Then(@"I see registered sucessfully message")]
        public void ThenISeeRegisteredSucessfullyMessage()
        {
            string newText = register_page.alertWindow();
            Assert.That(newText == "Registration successful", "The registration was unsuccessful, Please fix it");            
        }
        [Given(@"I logged into MarsQA Website sucessfully")]
        public void GivenILoggedIntoMarsQAWebsiteSucessfully()
        {
            //loginpage difinition
            signinpage.loginactions();
            signinpage.Clicksigninbutton();
            signinpage.Addemailaddress();
            signinpage.Addpassword();
            signinpage.Clickloginbutton();
        }
        [When(@"I navigate to skills tab and add skills")]
        public void WhenINavigateToSkillsTabAndAddSkills()
        {
            //profilepage difinition
            profilepage.AddSkills();
            profilepage.Clickaddnewbutton();
            profilepage.Addskill();
            profilepage.Addskilllevel();
            profilepage.Clickaddbutton();
        }
        [Then(@"The skills should be added to the profile sucessfully")]
        public void ThenTheSkillsShouldBeAddedToTheProfileSucessfully()
        {
            string newskill = profilepage.alertWindow();
            Assert.That(newskill == "Music20 has been added to your skills", "Music21 has not been matched correctly");
        }
        [When(@"I navigate to skills tab and update skills")]
        public void WhenINavigateToSkillsTabAndUpdateSkills()
        {
            profilepage.EditSkills();
            profilepage.Skilledit();
            profilepage.Editskill();
            profilepage.Updatebutton();
        }
        [Then(@"The skills should be updated to the profile sucessfully")]
        public void ThenTheSkillsShouldBeUpdatedToTheProfileSucessfully()
        {
            string editedskill = profilepage.alertWindow();
            Assert.That(editedskill == "chess4 has been updated to your skills", "Actual text and expected text do not match");
        }

        [When(@"I navigate to skills tab and delete skills")]
        public void WhenINavigateToSkillsTabAndDeleteSkills()
        {
            profilepage.DeleteSkills();
            profilepage.Skilldelete();
        }
        [Then(@"The skills should be deleted sucessfully")]
        public void ThenTheSkillsShouldBeDeletedSucessfully()
        {
            string DeletedSkill = profilepage.alertWindow();
            Assert.That(DeletedSkill == "chess4 has been deleted", "Actual data and expected data do Not match");
        }

        [When(@"I navigate to shareskills and give valid data")]
        public void WhenINavigateToShareskillsAndGiveValidData()
        {
            //shareskillspage definition
            shareskillpage.ShareSkills();
            shareskillpage.Entertitlename();
            shareskillpage.Enterdescription();
            shareskillpage.Selectcategory();
            shareskillpage.Selectsubcategory();
            shareskillpage.Addtag();
            shareskillpage.Clickoneoffservicebutton();
            shareskillpage.Clickonsitebutton();
            shareskillpage.Enterdates();
            shareskillpage.Addskillexchangetag();
            shareskillpage.Clicksavebutton();
        }
        [Then(@"The shareskills should be submitted sucessfully")]
        public void ThenTheShareskillsShouldBeSubmittedSucessfully()
        {
            string Createdcategory = shareskillpage.Getcreatedcategory();
            string createdtitle = shareskillpage.Getcreatedtitle();
            string createddescription = shareskillpage.Getcreateddescription();
            string createdservicetype = shareskillpage.Getcreatedservicetype();
            string createdactive = shareskillpage.Getcreatedactive();

            Assert.That(Createdcategory == "Music & Audio", "Actual category and expected category do Not match");
            Assert.That(createdtitle == "music for beginners", "Actual title and expected title do Not match");
            Assert.That(createddescription == "my hobbies are listening music", "Actual description and expected description do Not match");
            Assert.That(createdservicetype == "One-off", "Actual servicetype and expected servicetype do Not match");
            Assert.That(createdactive == "True", "Actual active and expected active do Not match");
        }
        [AfterScenario]
        public void TearDown()
        {            
            driver.Quit();
            driver.Dispose();
        }
    }
}



