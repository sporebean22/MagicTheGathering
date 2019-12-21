using System;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    static class Graveyard
    {
        public static readonly ArgumentException CannotDestroyException = new ArgumentException("This Card/s Cannot be Destroyed");
        public static readonly ArgumentException CannotReviveException = new ArgumentException("This Card/s Cannot be Revived");
        public static Dictionary<Card, int> GraveyardStore { get; } = new Dictionary<Card, int>();

        public static void Destroy(this Card card, int numberOfCards)
        {
            if (numberOfCards > 4 || numberOfCards < 1)
                throw CannotDestroyException;
            else
                GraveyardStore.Add(card, numberOfCards);
        }

        public static void Revive(this Card card, int numberOfCards)
        {
            if (numberOfCards > 4 || numberOfCards < 1)
                throw CannotReviveException;
            else
            {
                for(int index = 0; index < numberOfCards; index++)
                {
                    GraveyardStore.Remove(card);
                }
            }    
        }
    }
}
