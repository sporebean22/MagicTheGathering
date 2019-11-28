using System;
using System.Collections.Generic;
using MagicTheGathering;
using MagicTheGathering.Models;

namespace MTGGame
{
    class Program
    {
        private static INarrator narrator = new Narrator();
        public const _Lifepoints int = 40;
        
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
    
    public class Player
    {
        public List<Card> Deck = new List<Card>();
        public Lifepoints int { get; set; }
        
        public Player(List<Card> deck, int lifepoints)
        {
            this.Deck = deck;
            this.Lifepoints = lifepoints;
        }
    }
    
    public sealed class Game
    {
        private readonly INarrator _narrator;
        public Player[] Players { get; set; }
        
        public Game(Player[] players)
        {
            this.Players = players;
        }
        
        public void Start()
        {
            _narrator.GameStart()
             while(true)
            {
                
            }
        }
        
        public void GetHand()
        { 
        }
        
        public void Draw() {}
        public void DetermineFirstPlayer() {}
        public void Shuffle() {}
        
        public Player TurnManagement()
        {
            while(true)
            {
                
            }
                
        }
        enum Turns
        {
            EP,
            SP,
            BP,
            DP
        }
        
    }
}
