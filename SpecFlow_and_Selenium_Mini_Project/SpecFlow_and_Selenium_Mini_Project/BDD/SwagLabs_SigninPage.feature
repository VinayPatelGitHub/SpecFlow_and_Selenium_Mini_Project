Feature: SwagLabs_SigninPage
	In order to be able to buy items
	As a registered user of the automation practice website 
	I want to be able to sign in to my account 

@login
Scenario: Correct username and password
    Given I am on the signin page 
    And I have/haven't entered a username <usernames>
    And I have/haven't entered a password <password>
    When I click the sign in button 
    Then I should be taken to the login page with title header "Products"
    Examples:
    | usernames               | password     |
    | standard_user           | secret_sauce |
    | problem_user            | secret_sauce |
    | performance_glitch_user | secret_sauce |

@login
Scenario: incorrect login details
    Given I am on the signin page 
    And I have/haven't entered a username <usernames>
    And I have/haven't entered a password <password>
    When I click the sign in button 
    Then I should see a alert which says <alertText>
    Examples: 
    | usernames         | password     | alertText                                                                 |
    |                   |              | Epic sadface: Username is required                                        |
    | incorrectusername |              | Epic sadface: Password is required                                        |
    |                   | secret_sauce | Epic sadface: Username is required                                        |
    | incorrectusername | secret_sauce | Epic sadface: Username and password do not match any user in this service |
    | locked_out_user   | secret_sauce | Epic sadface: Sorry, this user has been locked out.                       |

