Feature: MarsQA Webiste

As a site user
I would like to register,signup and create profile
so that seller is able to see his profile details on the page

@tag1

Scenario:1) Signin to MarsQA Website with valid details
   Given I registered in MarsQA Website
   Then I see registered sucessfully message

Scenario:2) I will add skills in the MarsQA Website profile page
    Given I logged into MarsQA Website sucessfully
	When I navigate to skills tab and add skills
	Then The skills should be added to the profile sucessfully

Scenario:3) I will update skills in the MarsQA Website profile page
    Given I logged into MarsQA Website sucessfully
	When I navigate to skills tab and update skills
	Then The skills should be updated to the profile sucessfully

Scenario:4) I will delete skills in the MarsQA Website profile page
    Given I logged into MarsQA Website sucessfully
	When I navigate to skills tab and delete skills
	Then The skills should be deleted sucessfully

Scenario:5) I will submit share skill form  in the MarsQA Website profile page
    Given I logged into MarsQA Website sucessfully
	When I navigate to shareskills and give valid data
	Then The shareskills should be submitted sucessfully

#Scenario:6) I will add languages in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to languages tab and add language
#	Then The languages should be added to the profile sucessfully
#
#Scenario Outline:7) I will update languages in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to languages tab
#	And I will update '<Add Languages>','<Choose Language Level>' in the MarsQA Website profile page
#	Then The profile should have the updated'<AddLanguages>,'<Choose Language Level>'
#
#
#Examples: 
#|Add Languages||Choose Language Level|
#|English      ||     Basic           |
#|Spanish      ||     Fulent          |
#|Hindi        ||     Native          |
#
#Scenario:8) I will delete languages in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to languages tab and delete language
#	Then The language should be deleted sucessfully
#
#Scenario:9) I will add education in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to education tab and add education
#	Then The education should be added to the profile sucessfully
#
#Scenario:10) I will update education in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to education tab and update education
#	Then The education should be updated to the profile sucessfully
#
#Scenario:11) I will delete education in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to education tab and delete education
#	Then The education should be deleted sucessfully
#
#Scenario:12) I will add certifications in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to certifications tab and add certifications
#	Then The certifications should be added to the profile sucessfully
#
#Scenario:13) I will update certifications in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to certifications tab and update certifications
#	Then The certifications should be updated to the profile sucessfully
#
#Scenario:14) I will delete certifications in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to certifications tab and delete certifications
#	Then The certifications should be deleted sucessfully
#
#Scenario:15) I will add description in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to description tab and add description
#	Then The description should be added to the profile sucessfully
#
#Scenario:16) I will update description in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to description tab and update description
#	Then The description should be updated to the profile sucessfully
#
#Scenario:17) I will delete description in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to description tab and delete description
#	Then The description should be deleted sucessfully
#
#Scenario:18) I will add location in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to location tab and add location
#	Then The location should be added to the profile sucessfully
#
#Scenario:19) I will add availability in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to availability tab and add availability
#	Then The availability should be added to the profile sucessfully
#
#Scenario:20) I will add hours in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to hours tab and add hours
#	Then The hours should be added to the profile sucessfully
#
#Scenario:21) I will add earntarget in the MarsQA Website profile page
#    Given I logged into MarsQA Website sucessfully
#	When I navigate to earntarget tab and add earntarget
#	Then The earntarget should be added to the profile sucessfully
#








