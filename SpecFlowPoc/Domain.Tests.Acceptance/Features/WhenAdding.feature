Feature: AddNumbers
  In order to correctly do an add calculation between to numbers
  As a calculator user
  I want to be able to input two numbers and see the sum
  
Scenario: CorrectlyAddNumbers
  Given the numbers 5 and 6
  When adding the numbers
  Then the output should be 11
  