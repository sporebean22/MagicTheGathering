using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    class Instant : Spell
    {
        public Instant(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(effect, manaCost, cardName, terrainColour)
        { 
            
        }
    }
}
