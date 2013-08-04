Feature: Detailed params specification
	Here you may find different params combinations and miracles

Scenario: Using array as params
	Given simple array 1,2,3,4,5

Scenario: Using scenario outline
	Given I have entered [number1] into the calculator
	And   I have entered [number2] into the calculator
	Then  After calculation result is equal to [result]

Examples:
	|number1|number2|result|
	|	1   |	2	|	3  |
	|	3	|	4	|   7  |

Scenario: Table support in NBehave
	Given a list of books:
		|Title|ISBN|
		|aaaa |1234|
		|bbbb |2233|
		|aacc |3344|