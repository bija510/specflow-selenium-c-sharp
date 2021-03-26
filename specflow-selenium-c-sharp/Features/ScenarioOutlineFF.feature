Feature: facebook login page
	

@ScenarioOutline
Scenario Outline: facebook login 
	Given the user is in fb login page
	Then the user input user Name <userName>
	And the user input password <password>
	Then the user close browser

	Examples: 
	| userName |  password |
	| admin    |  admin123 |
	| Bin      |  bin123   |
	| cavin    |  cavin123 |