Feature: localhost

As a site user
I would like to register,signup and create profile
so that seller is able to see his profile details on the page

@tag1

Scenario:1) Signin to localhost with valid details
   Given I registered in localhost
   Then I see registered sucessfully message

Scenario:2) I will add skills in the localhost profile page
    Given I logged into localhost sucessfully
	When I navigate to skills tab and add skills
	Then The skills should be added to the profile sucessfully

Scenario:3) I will update skills in the localhost profile page
    Given I logged into localhost sucessfully
	When I navigate to skills tab and update skills
	Then The skills should be updated to the profile sucessfully

Scenario:4) I will delete skills in the localhost profile page
    Given I logged into localhost sucessfully
	When I navigate to skills tab and delete skills
	Then The skills should be deleted sucessfully

Scenario:5) I will submit share skill form  in the localhost profile page
    Given I logged into localhost sucessfully
	When I navigate to shareskills and give valid data
	Then The shareskills should be submitted sucessfully





