Feature: GoogleSearch
	Tanya is awesome and this example is for her!

Scenario: Search google for laptops
	Given I am at 'http://www.google.com'
	When I search for 'laptop'
	Then I should see '11' results containing 'laptop'
