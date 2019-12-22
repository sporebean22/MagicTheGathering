using MagicTheGathering;
using MagicTheGathering.Models;
using System.Collections.Generic;

namespace MTGGame
{
    public class Player
    {
        public HP HP { get; set; }
        public string Name { get; set; }
        public List<Card> Deck { get; set; } = new List<Card>();
        public int LifePoints { get; set; }

        public Player(string name, List<Card> deck, int lifepoints)
        {
            Name = name;
            Deck = deck;
            LifePoints = lifepoints;
        }

        public Card[] Draw(int cardsToDraw)
        {
            var cardsDrawn = new Card[cardsToDraw];
            for (int cardIndex = 0; cardIndex < cardsToDraw; cardIndex++)
            {
                cardsDrawn.SetValue(Deck[cardIndex], cardIndex);
            }

            return cardsDrawn;
        }

        public void Shuffle()
        {

        }
    }
}
