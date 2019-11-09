
using System;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    static class Graveyard
    {
        public static readonly ArgumentException CannotDestroyException = new ArgumentException("This Card Cannot be Destroyed");
        public static Dictionary<Card, int> GraveyardStore { get; } = new Dictionary<Card, int>();

        public static string Destroy(this Card card, int value)
        {
            if (value > 4 || value < 1)
                throw CannotDestroyException;
            GraveyardStore.Add(card, value);
            return $"{value} of {card} has been Destroyed";
        }
    }
}
