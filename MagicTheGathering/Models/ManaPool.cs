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
            foreach (KeyValuePair<TerrainColour, int> manaPair in manaCost)
            {
                Mana[manaPair.Key] =- manaPair.Value;
            }

            //Mana = Mana.Select(manaPair => Mana[manaPair.Key] - manaPair.Value));
        }

        //private static KeyValuePair<TerrainColour, int> DeductMana(KeyValuePair<TerrainColour, int> manaPair)
        //{
        //    var a = Mana[manaPair.Key] - manaPair.Value;
        //    return new KeyValuePair<TerrainColour, int>
        //    {
        //        {manaPair.Key, a }
        //    }
        }
    }
}
