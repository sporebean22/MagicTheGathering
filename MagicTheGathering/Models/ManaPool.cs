using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    public class ManaPool
    {
        public static Dictionary<TerrainColour, int> Mana { get; set; } = new Dictionary<TerrainColour, int>();

        public static void Cast(Dictionary<TerrainColour, int> manaCost)
        {

        }

        public static Dictionary<TerrainColour, int> GetMana()
        {
            return Mana;
        }
    }
}
