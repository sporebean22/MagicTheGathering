using System;
using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Sorcery : Spell
    {
        public override string CardName { get; set; }
        public override TerrainColour TerrainColour { get; set ; }

        public Sorcery(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(effect, manaCost, cardName, terrainColour)
        {
            SpellEffect = effect ?? throw new ArgumentNullException(nameof(effect));
            ManaCost = manaCost ?? throw new ArgumentNullException(nameof(manaCost));
            CardName = cardName ?? throw new ArgumentNullException(nameof(cardName));
            TerrainColour = terrainColour;
        }

        public void CastEffect()
        {
            SpellEffect();
        }
    }
}
