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

@AllItemsPage
Scenario: AddtoBasketLogoutandLoginCheckBasket
    Given I am on the AllitemsPage
    And I add item to basket
    And Logout then back in
    When I click the basket
    Then I should see the item "Sauce Labs Backpack" in basket

@AllItemsPage
Scenario: RemoveFromBasket
    Given I am on the AllitemsPage
    And I add item to basket
    And I click the basket
    When I remove from basket
    Then I shouldn't see the item "Sauce Labs Backpack" in basket


