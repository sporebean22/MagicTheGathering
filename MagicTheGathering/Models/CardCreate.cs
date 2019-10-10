using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    public abstract class Card : ICard
    {
        public abstract string ManaCost { get; set; }
               
        public abstract string CardName { get; set; }
               
        public abstract TerrainColour Colour { get; set; }
               
        public abstract int Attack { get; set; }
               
        public abstract int Toughness { get; set; }

        public Card(string cardname, TerrainColour colour, int Attack, int Toughness)
        {
            
        }
    }
}
