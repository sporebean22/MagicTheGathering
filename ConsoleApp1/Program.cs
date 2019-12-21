using System;
using System.Collections.Generic;
using MagicTheGathering;
using MagicTheGathering.Models;
using MTGGame;

namespace MTGGame
{
    class Program
    {
        private static INarrator narrator = new Narrator();
        public const int _Lifepoints = 40;

        public static void Main()
        {
            var manacost = new Dictionary<TerrainColour, int>()
            {
                { TerrainColour.Blue, 5},
                { TerrainColour.Green, 5}
            };

            //var card = new Card(manacost, "test", Terraincolour.Blue);

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

