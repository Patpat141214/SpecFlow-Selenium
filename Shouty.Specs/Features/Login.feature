Feature: Login
  To ensure only valid users can access the system

  Scenario: Successful login
    Given the user is on the login page
    When the user enters valid credentials
    Then the user should be redirected to the homepage

  Scenario: Invalid login
    Given the user is on the login page
    When the user enters invalid credentials
    Then an error message should be displayed