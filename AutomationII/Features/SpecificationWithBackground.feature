Feature: Support for background sections

Background:
	Given I have entered 10 into the calculator
	And   I have entered 15 into the calculator

Scenario: Running a first scenario with background
	Given I have entered 100 into the calculator

Scenario: Running a second scenario with background
	Given I have entered 200 into the calculator