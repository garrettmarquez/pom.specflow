Feature: Sample

@mytag
Scenario Outline: Sample
	Given I Launch Application <client>
	When I Enter Credentials <email> <password>
	Examples: 
	| client			| email				| password |
	| aucklandtransport	| email@domain.com	| pass4321 |