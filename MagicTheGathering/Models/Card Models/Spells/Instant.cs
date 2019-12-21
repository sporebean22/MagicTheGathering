using System;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Instant : Spell
    {
        public override Dictionary<TerrainColour, int> ManaCost { get => base.ManaCost; set => base.ManaCost = value; }
        public override string CardName { get => base.CardName; set => base.CardName = value; }
        public override TerrainColour TerrainColour { get => base.TerrainColour; set => base.TerrainColour = value; }

        public Instant(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(effect, manaCost, cardName, terrainColour)
        {
            SpellEffect = effect;
            ManaCost = manaCost;
            CardName = cardName;
            TerrainColour = TerrainColour;
        }
    }
}
