using System;
using MagicTheGathering.Models.Card_Models;
using System.Collections.Generic;

namespace MagicTheGathering
{
    public abstract class Card : Permanent
    {
        public Dictionary<TerrainColour, int> ManaCost { get; set; } = new Dictionary<TerrainColour, int>();

        public abstract string CardName { get; set; }

        public abstract TerrainColour TerrainColour { get; set; }

        public Card(Dictionary<TerrainColour, int> manacost, string cardname, TerrainColour terrainColour)
        {
            ManaCost = manacost ?? throw new ArgumentNullException(nameof(manacost));
            CardName = cardname ?? throw new ArgumentNullException(nameof(cardname));
            TerrainColour = terrainColour;
        }
    }
}