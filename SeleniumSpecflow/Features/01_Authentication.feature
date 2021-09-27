Feature: Buggy Cars Rating Authentication
	As a user, I want to be able to log in
	And be authenticated into the site
	So that I can use personalised services


@Login @Valid
Scenario: To test the Login fuctionality with valid credentials
	Given I am a user with valid credentials	
	When I log into the application
	Then I should be able to login succesfully

	
@Login @Invalid
Scenario: To test the Login with invalid credentials
	Given I am a user with invalid credentials
	When I log into the application
	Then I should be not be able to login successfully

	
@Logout @Valid
Scenario: To test Logout functionality
	Given I am logged in
	When I click the Logout link
	Then I should be logged off

 

##Other possible scenarios 
#@Login @Invalid
#Scenario Outline: To test the Login with invalid credentials
#	Given I enter my user detail
#	When I log into the application
#	Then I should be not be able to login successfully
#	Examples: 
#	| Scenario                     | ScenarioDescription |
#	#Username
#	| Invalid Username             |                     |
#	| SQLInsertionUsername         |                     |
#	| BlankUsername                |                     |
#	| MinimumLengthMissingUsername |                     |
#	#Password
#	| InvalidPassword              |                     |
#	| SQLInsertionPassword         |                     |
#	| BlankPassword                |                     |
#	| MinimumLengthMissingPassword |                     |
#	| MissingNumbersPassword       |                     |
#	| MissingLettersPassword       |                     |
#	#Username#Password
#	| BlankUserNameBlankPassword   |                     |
#	| ProfaneWordUsage             |                     |
#
#
