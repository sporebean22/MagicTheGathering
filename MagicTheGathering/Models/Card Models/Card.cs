using System;
using MagicTheGathering.Models.Card_Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MagicTheGathering
{
    [Serializable]
    public abstract class Card : Permanent, ISerializable
    {
        public abstract Dictionary<TerrainColour, int> ManaCost { get; set; }

        public abstract string CardName { get; set; }

        public abstract TerrainColour TerrainColour { get; set; }

        public Card(Dictionary<TerrainColour, int> manacost, string cardname, TerrainColour terrainColour)
        {
            ManaCost = manacost ?? throw new ArgumentNullException(nameof(manacost));
            CardName = cardname ?? throw new ArgumentNullException(nameof(cardname));
            TerrainColour = terrainColour;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        { 
        
        }

    }
}