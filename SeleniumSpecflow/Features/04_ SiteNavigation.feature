Feature: Buggy Cars Rating SiteNavigation
	Site Navigation

Background: 
Given I am logged in

Scenario: Navigation to home page from various pages
	Then I navigate to Popular Model then confirm model page and back to main page successfully
	Then I navigate to Overall Rating then confirm overall page and back to main page succesfully
	