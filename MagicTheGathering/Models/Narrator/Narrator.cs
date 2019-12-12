using MTGGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exception = System.Exception;

namespace MagicTheGathering.Models
{
    public class Narrator : INarrator
    {
        public Exception TooManyPlayersException = new Exception("There Cannot be more than 4 players in one given Game.");

        public Narrator() { }

        public string GameBegin()
            => "The Magic The Gathering Game has Begun!, may the Players shuffle their Decks and Draw 5 Cards";
        public string NarrateSpellBasic(Spell spell)
            => $"The {spell.TerrainColour}, {spell.CardName} Has been Cast! with a ManaCost of: {spell.ManaCost}.";
        public string NarrateSpellBasic(TerrainColour terrainColour, string cardName, Dictionary<TerrainColour, int> manaCost)
            => $"The {terrainColour}, {cardName} Has been Cast! with a ManaCost of: {manaCost}.";
        public string NarrateBasicMonster(Monster monster)
            => $"The {monster.TerrainColour} {monster.MonsterType}, {monster.CardName} Has been Cast! with a ManaCost of: {monster.ManaCost}.";
        public String GameStart(List<Player> players)
        {
            var text = new StringBuilder($"The Game has Started! The Players are: ");

            foreach (Player player in players)
            {
                return text.Append(player.Name).ToString();
            }
            =>  $"The {monster.TerrainColour} {monster.MonsterType}, {monster.CardName} Has been Cast! with a ManaCost of: {monster.ManaCost}.";
        public string NarrateCardCast(Card card)
            => $"The Card {card.CardName} has been Cast! with a Manacost of {TranslateDictionary(card.ManaCost)}";
        public Narrator() { }

            return text.Append("may the Game Begin!").ToString();
        }
    }
}