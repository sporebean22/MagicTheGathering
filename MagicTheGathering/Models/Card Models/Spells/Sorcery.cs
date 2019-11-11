using System;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Sorcery : Spell
    {
        public Sorcery(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(effect, manaCost, cardName, terrainColour)
        {

        }
    }
}
