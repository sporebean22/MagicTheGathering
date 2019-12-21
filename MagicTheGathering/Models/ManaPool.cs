using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class ManaPool
    {
        public static Dictionary<TerrainColour, int> Mana { get; set; } = new Dictionary<TerrainColour, int>();

        public static void Cast(Dictionary<TerrainColour, int> manaCost)
        {
            foreach (KeyValuePair<TerrainColour, int> manaPair in manaCost)
            {
                Mana[manaPair.Key] = -manaPair.Value;
            }

            //Mana = Mana.Select(manaPair => Mana[manaPair.Key] - manaPair.Value));
        }
    }
}
