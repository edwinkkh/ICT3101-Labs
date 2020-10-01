Feature: failure
	In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@Failure Intensity
Scenario: Calculating Current Intensity
	Given I have a verification and validation
	When I have entered "10" and "50" and "100" into the calculator and press current failure
	Then the current intensity result should be "5"

@Failure Intensity
Scenario: Calculating Average Intensity
	Given I have a verification and validation
	When I have entered "<initalFailure>" and "<IntensityTotalFailure>" and "<time>" into the calculator and press average failure
	Then The average failure result should be "<result>"

	Examples:
		| initalFailure | IntensityTotalFailure | time | result |
		| 10            | 100                   | 10   | 63     |
		| 10            | 100                   | 100  | 100    |