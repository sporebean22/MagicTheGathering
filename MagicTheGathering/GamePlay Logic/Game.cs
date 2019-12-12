using MagicTheGathering.Models;
using MTGGame;

public sealed partial class Game
    {
        private readonly INarrator _narrator;
        public Player[] Players { get; set; }
        
        public Game(Player[] players)
        {
            this.Players = players;
        }
        
        public void Start()
        {

            _narrator.GameStart();

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
        
    }
}
