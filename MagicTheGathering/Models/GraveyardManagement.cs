
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    class Graveyard : IGraveYard
    {
        public static Dictionary<Card, int> GraveyardStore { get; } = new Dictionary<Card, int>();

        //public static void addtograveryard(Card card)


    }
}
