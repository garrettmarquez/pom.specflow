Feature: Auckland Transport Sample Feature

@mytag
Scenario Outline: This is just a sample feature file for Auckland Transport website
	Given I Launch Application <client>
	When I Enter Credentials <email> <password>
	Examples: 
	| client			| email				| password |
	| aucklandtransport	| email@domain.com	| pass4321 |