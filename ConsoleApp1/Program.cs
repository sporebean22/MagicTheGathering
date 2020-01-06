using System;
using System.Collections.Generic;
using MagicTheGathering;
using MagicTheGathering.Models;
using MagicTheGathering.Models.JsonManagement;
using MTGGame;

namespace MTGGame
{
    class Program
    {
        private static INarrator narrator = new Narrator();
        private static IJsonManagement _jsonManagement = new JsonManagement();
        public const int _Lifepoints = 40;

        public static void Main()
        {
            var manaCost = new Dictionary<TerrainColour, int>()
            {
                { TerrainColour.Blue, 5},
                { TerrainColour.Green, 5}
            };

            var card1 = new Monster( manaCost, "DinosaurMan", MonsterType.Dinosaur, TerrainColour.Black, 5, 5);

            var card2 = new Monster(new Effect("Burn"), manaCost, "Monsterboi", MonsterType.Dinosaur, TerrainColour.Black, 5,5 );

            _jsonManagement.SaveToFile<Monster>(card2, $"{card2.CardName}");

        }
            
            /*var deck1 = new List<Card>();
            var deck2 = new List<Card>();
            var player1 = new Player("testo", deck1, _Lifepoints);
            var player2 = new Player("Test", deck2, _Lifepoints);               
            
            var players = new Player[] { player1, player2 };
            
            var game = new Game(players);
            game.Start();*/
            
            /*
            Console.WriteLine(narrator.GameBegin());
            var IronForgeManaCost = new Dictionary<TerrainColour, int>();
            var monster = new Monster(IronForgeManaCost, "Dragon of the Iron Forge", MonsterType.Dragon ,TerrainColour.Red, 5,5);
            Console.WriteLine(narrator.NarrateBasicMonster(monster)); 
            */
        }
    }    

