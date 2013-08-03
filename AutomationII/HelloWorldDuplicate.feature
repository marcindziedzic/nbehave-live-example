Feature: HelloWorldDuplicate
  A narrative is optional

Scenario: Log in as Marcin
  Given I am not logged in
  When I log in as Marcin with a password SecretPassw0rd
  Then I should see a message, "Welcome, Marcin!"