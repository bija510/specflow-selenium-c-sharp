Feature: RegisterFF
	sign up the form

@mytag
Scenario: Fill up the register form
	Given i lunch the application
	And i enter the first name
	Then i enter the last name
	| firstName | lastname |
	| Ram		| Sharma	   |
	Then i click the register