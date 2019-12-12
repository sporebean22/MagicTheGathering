using System;
using System.Collections.Generic;
using MagicTheGathering;
using MagicTheGathering.Models;

namespace MTGGame
{
    class Program
    {
        private static INarrator narrator = new Narrator();
        public const int _Lifepoints = 40;
        
        public static void Main()   
        {  
            var player1 = new Player(_Lifepoints, new List<Card> Deck1);
            var player2 = new Player(_Lifepoints, new List<Card> Deck2);               
            
            var players = new Player[] { player1, player2 };
            
            var game = new Game(players);
            game.Start();
            
            /*
            Console.WriteLine(narrator.GameBegin());
            var IronForgeManaCost = new Dictionary<TerrainColour, int>();
            var monster = new Monster(IronForgeManaCost, "Dragon of the Iron Forge", MonsterType.Dragon ,TerrainColour.Red, 5,5);
            Console.WriteLine(narrator.NarrateBasicMonster(monster)); 
            */
        }
    }
        }
    }
