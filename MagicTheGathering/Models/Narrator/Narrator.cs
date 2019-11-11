using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Narrator : INarrator
    {
        public string GameBegin()
            => "The Magic The Gathering Game has Begun!, may the Players shuffle their Decks and Draw 5 Cards";
        public string NarrateSpellBasic(Spell spell)
            =>  $"The {spell.TerrainColour}, {spell.CardName} Has been Cast! with a ManaCost of: {spell.ManaCost}.";
        public string NarrateSpellBasic(TerrainColour terrainColour, string cardName, Dictionary<TerrainColour,int> manaCost)
            =>  $"The {terrainColour}, {cardName} Has been Cast! with a ManaCost of: {manaCost}.";
        public string NarrateBasicMonster(Monster monster)
            =>  $"The {monster.TerrainColour} {monster.MonsterType}, {monster.CardName} Has been Cast! with a ManaCost of: {monster.ManaCost}.";

        public Narrator() { }

    }
}
