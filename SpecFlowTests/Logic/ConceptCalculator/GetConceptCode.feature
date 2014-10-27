Feature: GetConceptCode
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add two numbers
	Given The <previous> concept value and <current> concept value
	Then the <conceptCode> should be valid
	Examples: 
	| previous | current | conceptCode |
	| "1"      | "1"     | "Negative1" |
