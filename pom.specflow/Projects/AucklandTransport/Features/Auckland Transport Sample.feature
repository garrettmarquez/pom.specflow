Feature: Sample

@mytag
Scenario Outline: Auckland Transport Sample
	Given I Launch Application <client>
	When I Enter Credentials <email> <password>
	Examples: 
	| client			| email				| password |
	| aucklandtransport	| email@domain.com	| pass4321 |