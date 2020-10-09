Feature: factorial
	In order to solve factorial
	As a math idiot
	I want to be factorial the number

@Factorial
Scenario: Factorial numbers
	Given a number
	When the factorial is "<value1>"
	Then The factorial result should be "<value2>"

	Examples:
		| value1 | value2 |
		| 3      | 6      |
		| 1      | 1      |

@Factorial
Scenario: Factorial numbers negative
	Given a number
	When the factorial is negative
	Then The factorial result should be error