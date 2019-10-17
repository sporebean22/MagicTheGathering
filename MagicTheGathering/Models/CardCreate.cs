using MagicTheGathering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    public abstract class Card : ICard
    {
        public Dictionary<TerrainColour, int> ManaCost { get; } = new Dictionary<TerrainColour, int>();

        public abstract string CardType { get; set; }

        public string CardName { get; }

        public abstract int Attack { get; set; }

        public abstract int Toughness { get; set; }

        public Card(Dictionary<TerrainColour, int> manacost, string cardname, TerrainColour colour, int attack, int toughness)
        {
            ManaCost = manacost;
            CardName = cardname;
            Attack = attack;
            Toughness = toughness;
        }
    }
}