using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecflowTask.pages;
using SpecflowTask.utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTask.stepdefinition
{
    [Binding]
    public class MarsQAWebsiteStepDefinitions : Commondriver
    {
        register_page registerpageobj = new register_page();
        signinpage loginpageobj = new signinpage();
        profilepage profilepageobj = new profilepage();
        shareskillpage shareskillpageobj = new shareskillpage();

       [Given(@"I registered in MarsQA Website")]
        public void GivenIRegisteredMarsQAWebsiteSucessfully()
        { 
            //Registerpage object intialization and difinition
            registerpageobj.registeractions(driver);

        }
        [Then(@"I see registered sucessfully message")]
        public void ThenISeeRegisteredSucessfullyMessage()
        {
            string newText = registerpageobj.alertWindow(driver);

            Assert.That(newText == "Registration successful", "The registration was unsuccessful, Please fix it");
        }
        [Given(@"I logged into MarsQA Website sucessfully")]
        public void GivenILoggedIntoMarsQAWebsiteSucessfully()
        {            
            //loginpage object intialization and difinition
            loginpageobj.loginactions(driver);
        }
        [When(@"I navigate to skills tab and add skills")]
        public void WhenINavigateToSkillsTabAndAddSkills()
        {
            //profilepage object intialization and difinition
            profilepageobj.AddSkills(driver);
        }
        [Then(@"The skills should be added to the profile sucessfully")]
        public void ThenTheSkillsShouldBeAddedToTheProfileSucessfully()
        {
            string addedskill = profilepageobj.alertWindow(driver);
            Assert.That(addedskill == "Music23 has been added to your skills", "Music21 has not been matched correctly");
        }
        [When(@"I navigate to skills tab and update skills")]
        public void WhenINavigateToSkillsTabAndUpdateSkills()
        {
            profilepageobj.EditSkills(driver);
        }
        [Then(@"The skills should be updated to the profile sucessfully")]
        public void ThenTheSkillsShouldBeUpdatedToTheProfileSucessfully()
        {
            string editedskill = profilepageobj.alertWindow(driver);
            Assert.That(editedskill == "chess4 has been updated to your skills", "Actual text and expected text do not match");
            
        }

        [When(@"I navigate to skills tab and delete skills")]
        public void WhenINavigateToSkillsTabAndDeleteSkills()
        {
            profilepageobj.DeleteSkills(driver);
        }
        [Then(@"The skills should be deleted sucessfully")]
        public void ThenTheSkillsShouldBeDeletedSucessfully()
        {
            string DeletedSkill = profilepageobj.alertWindow(driver);
            Assert.That(DeletedSkill == "chess4 has been deleted", "Actual data and expected data do Not match");
        }


        [When(@"I navigate to shareskills and give valid data")]
        public void WhenINavigateToShareskillsAndGiveValidData()
        {
            shareskillpageobj.ShareSkills(driver);
        }
        [Then(@"The shareskills should be submitted sucessfully")]
        public void ThenTheShareskillsShouldBeSubmittedSucessfully()
        {
            string Createdcategory = shareskillpageobj.Getcreatedcategory(driver);
            string createdtitle = shareskillpageobj.Getcreatedtitle(driver);
            string createddescription = shareskillpageobj.Getcreateddescription(driver);
            string createdservicetype = shareskillpageobj.Getcreatedservicetype(driver);
            string createdactive = shareskillpageobj.Getcreatedactive(driver);

            Assert.That(Createdcategory == "Music & Audio", "Actual category and expected category do Not match");
            Assert.That(createdtitle == "music for beginners", "Actual title and expected title do Not match");
            Assert.That(createddescription == "my hobbies are listening music", "Actual description and expected description do Not match");
            Assert.That(createdservicetype == "One-off", "Actual servicetype and expected servicetype do Not match");
            Assert.That(createdactive == "True", "Actual active and expected active do Not match");
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }

    }







}



