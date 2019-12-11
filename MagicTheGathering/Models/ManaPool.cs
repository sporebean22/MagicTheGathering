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

        public static void Cast()
        {

        }

        public static Dictionary<TerrainColour, int> GetMana()
        {
            return Mana;
        }

        public static string TranslateDictionary()
        {
            var ManaString = new StringBuilder();

            for (TerrainColour i in foreach( int j in Enum.GetValues(typeof(TerrainColour))); i != Mana.Count; i++)
            {
                var test = Mana[i];
                ManaString.Append("/n ");
            }
        }

    }
}
