using MagicTheGathering;
using System.Collections.Generic;
using System.Text;

namespace MTGGame
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Deck { get; set; } = new List<Card>();
        public int LifePoints { get; set; }

        public Player(string name, List<Card> deck, int lifepoints)
        {
            Name = name;
            Deck = deck;
            LifePoints = lifepoints;
        }

        public List<Card> GetHand()
        {
            //Deck will need to be shuffled
            for ()
            {

            }
        }
    }
}
