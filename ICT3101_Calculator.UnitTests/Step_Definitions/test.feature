Feature: test
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Addition
Scenario: Add two numbers
	Given a calculator
	When I have entered "20" and "50" into the calculator press add
	Then The result should be "70"

@Addition
Scenario Outline: Add zero for special cases
	Given a calculator
	When I have entered "<value1>" and "<value2>" into the calculator press add
	Then The result should be "<value3>"

	Examples:
		| value1 | value2 | value3 |
		| 0      | 20     | 20     |
		| 20     | 0      | 200    |
		| 0      | 0      | 666    |