using MagicTheGathering;
using System.Collections.Generic;

namespace MTGGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Deck { get; set; } = new List<Card>();
        public int LifePoints { get; set; }
    }
}
