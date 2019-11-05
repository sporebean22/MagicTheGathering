using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
    public abstract class Card : ICard
    {
        public Dictionary<TerrainColour, int> ManaCost { get; } = new Dictionary<TerrainColour, int>();

        public abstract string CardType { get; }

        public string CardName { get; }

        public TerrainColour TerrainColour { get; set; }

        public Card(Dictionary<TerrainColour, int> manacost, string cardname, TerrainColour terrainColour)
        {
            ManaCost = manacost ?? throw new ArgumentNullException(nameof(manacost));
            CardName = cardname ?? throw new ArgumentNullException(nameof(cardname));
            TerrainColour = terrainColour;
        }
    }
}