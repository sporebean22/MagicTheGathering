Feature: MagicManaTests

Scenario: Successfully Add 10 Green Mana into the Mana Pool
	Given I have Started a Game
	When I Add '10' 'Green' Mana into the Mana Pool
	Then the Mana Request Response Should look like:
	| Mana  | Value |
	| Green | 10    |
