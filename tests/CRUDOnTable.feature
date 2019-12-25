Feature: Create

Scenario: Create db entry
    Given: Table student exists
    When: User create student with id '1' name 'Pramod' and class 'BE'
    Then: DB should have entry for id '1' name 'Pramod' class 'BE'