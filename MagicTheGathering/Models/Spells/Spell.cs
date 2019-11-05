using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    class Spell : Card
    {
        public override string CardType { get; } = "Spell";

        public Func<Effect> Effect { get; set; }

        public Spell(Func<Effect> effect, Dictionary<TerrainColour, int> manacost, string cardName, TerrainColour terrainColour) : base(manacost, cardName, terrainColour)
        { 
            
        }
    }
}
