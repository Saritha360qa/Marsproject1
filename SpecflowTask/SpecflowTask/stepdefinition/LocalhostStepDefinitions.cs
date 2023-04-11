using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecflowTask.pages;
using SpecflowTask.utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTask.stepdefinition
{
    [Binding]
    public class LocalhostStepDefinitions:Commondriver
    {
        register_page registerpageobj = new register_page();
        signinpage loginpageobj = new signinpage();
        profilepage profilepageobj = new profilepage();
        shareskillpage shareskillpageobj = new shareskillpage();

       [Given(@"I registered in localhost")]
        public void GivenIRegisteredLocalhostSucessfully()
        {
            //Open chrome browser
            //driver = new ChromeDriver();

            //Registerpage object intialization and difinition
            registerpageobj.registeractions(driver);

        }
        [Then(@"I see registered sucessfully message")]
        public void ThenISeeRegisteredSucessfullyMessage()
        {
            string newText = registerpageobj.GetText(driver);

            Assert.That(newText == "Registration successful", "The registration was unsuccessful, Please fix it");
            //driver.Quit();

        }
        [Given(@"I logged into localhost sucessfully")]
        public void GivenILoggedIntoLocalhostSucessfully()
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
            string addedskill = profilepageobj.GetaddedText(driver);
            string newskill = profilepageobj.Getaddskill(driver);
            string newskilllevel = profilepageobj.Getaddskilllevel(driver);
            Assert.That(addedskill == "Music3 has been added to your skills", "Actual text and expected text do not match");
            Assert.That(newskill == "Music3", "Actual skill and expected skill do Not match");
            Assert.That(newskilllevel == "Expert", "Actual skilllevel and expected skilllevel do Not match");
        }
        [When(@"I navigate to skills tab and update skills")]
        public void WhenINavigateToSkillsTabAndUpdateSkills()
        {
            profilepageobj.EditSkills(driver);
        }
        [Then(@"The skills should be updated to the profile sucessfully")]
        public void ThenTheSkillsShouldBeUpdatedToTheProfileSucessfully()
        {
            string CreatedSkill = profilepageobj.GetEditSkill(driver);
            string CreatedSkilllevel = profilepageobj.GetEditSkilllevel(driver);

            Assert.That(CreatedSkill == "chess2", "Actual skill and expected skill do Not match");
            Assert.That(CreatedSkilllevel == "Beginner", "Actual skilllevel and expected skilllevel do Not match");
        }

        [When(@"I navigate to skills tab and delete skills")]
        public void WhenINavigateToSkillsTabAndDeleteSkills()
        {
            profilepageobj.DeleteSkills(driver);
        }
        [Then(@"The skills should be deleted sucessfully")]
        public void ThenTheSkillsShouldBeDeletedSucessfully()
        {
            string DeletedSkill = profilepageobj.GetText(driver);
            Assert.That(DeletedSkill == "chess2 has been deleted", "Actual data and expected data do Not match");
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



