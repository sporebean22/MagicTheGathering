using MagicTheGathering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    public class Card
    {
        public Dictionary<TerrainColour, int> ManaCost { get; } = new Dictionary<TerrainColour, int>();

        public string CardName { get; }

        public Card(Dictionary<TerrainColour, int> manaCost, string cardName)
        {
            ManaCost = manaCost;
            CardName = cardName;
        }
    }
}