Feature: HelloWorld
  A narrative is optional

Scenario: Log in as Morgan
  Given I am not logged in
  When I log in as Morgan Freeman with a password SecretPassw0rd
  Then I should see a message, "Welcome, Morgan!"

Scenario: Log in as Kate
  Given I am not logged in
  When I log in as Kate with a password OtherSecretPass
  Then I should see a message, "Welcome, Kate!"