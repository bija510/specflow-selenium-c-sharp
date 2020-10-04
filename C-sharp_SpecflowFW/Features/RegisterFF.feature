Feature: RegisterFF
	sign up the form

@MultipleDataTable
Scenario: Fill the Employee Name
	Given i lunch the application
	And i enter the first name
	Then i enter the last name
	| firstName | lastname |
	| Ram       | Sharma   |
	Then i click the register

Scenario: Fill up the register form
	
	Then i enter all the information
	| firstName | lastname | phoneNumber |
	| Adam		| john     | 123456789   |
	| Bin		| lee      | 123456789   |
	| David		| johnson  | 123456789   |

	
