using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
    public abstract class Card
    {
        public Dictionary<TerrainColour, int> ManaCost { get; set; } = new Dictionary<TerrainColour, int>();

        public string CardName { get; set; }

        public TerrainColour TerrainColour { get; set; }

        public Card(Dictionary<TerrainColour, int> manacost, string cardname, TerrainColour terrainColour)
        {
            ManaCost = manacost ?? throw new ArgumentNullException(nameof(manacost));
            CardName = cardname ?? throw new ArgumentNullException(nameof(cardname));
            TerrainColour = terrainColour;
        }
    }
}