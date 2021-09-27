Feature: Buggy Cars Rating Registration
	As a user, I want to be able to register
	And be authenticated into the site
	So that I can use personalised services
		
@Registration @Valid
Scenario: To test the registration process
	Given I register on the site using:
	| Login  | First Name | Last Name | Password   | Confirm Password |
	| random | random     | random    | Test01234! | Test01234!       |
	When verify registration is a success
	Then I use created credentials to log in successfully
