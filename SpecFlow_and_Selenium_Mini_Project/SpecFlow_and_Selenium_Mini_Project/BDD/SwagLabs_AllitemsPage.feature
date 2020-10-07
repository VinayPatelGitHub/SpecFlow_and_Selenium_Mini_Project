Feature: SwagLabs_AllitemsPage
	In order to be able to buy items
	As a registered user of the automation practice website 
	I want to be able to sign in to my account 

@AllItemsPage
Scenario: AddtoBasket
    Given I am on the AllitemsPage
    And I add item to basket
    When I click the basket
    Then I should see the item "Sauce Labs Backpack" in basket
