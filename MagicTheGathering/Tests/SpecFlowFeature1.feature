Feature: Creating a json file from a card object

Scenario: Creating a json file for a basic monster
	Given I have created a basic monster with the following ManaCost:
	| TerrainColor | Value |
	| Blue         | 2     |
	| Colourless   | 5     |
	And the following propeties:
	| CardName                  | MonsterType | TerrainColour | Attack | Toughness |
	| Monster of the flying sea | Basilisk    | Blue          | 5      | 5         |
	When the json file generation is triggered
	Then the file is found in the directory '' with filename of ''