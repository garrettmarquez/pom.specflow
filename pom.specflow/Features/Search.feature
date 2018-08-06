Feature: Search
	In order to view the contents related to my search input
	As a site visitor
	I want to search using the search textbox

@mytag
Scenario: Simple Search
	Given Planit Website is open
	When I search for something
	Then the result should be displayed