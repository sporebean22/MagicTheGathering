using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    static class Narrator
    {
        public static string NarrateSpellBasic(string cardName, Dictionary<TerrainColour, int> manaCost)
        {
            return $"The {cardName} Has been Cast! with a ManaCost of: {manaCost}.";
        }
    }
}
