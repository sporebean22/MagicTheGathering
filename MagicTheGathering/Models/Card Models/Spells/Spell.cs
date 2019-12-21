using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    public abstract class Spell : Card
    {
        public override Dictionary<TerrainColour, int> ManaCost { get; set; }
        public static Delegate SpellEffect { get; set; }
        public override string CardName { get; set; }
        public override TerrainColour TerrainColour { get; set; }

        public Spell(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(manaCost, cardName, terrainColour)
        {
            SpellEffect = effect;
            ManaCost = manaCost;
            CardName = cardName;
            TerrainColour = terrainColour;
        }
    }
}
