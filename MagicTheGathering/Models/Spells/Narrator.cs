using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    static class Narrator
    {
        public static string NarrateSpellBasic(string cardType, string cardName, Dictionary<TerrainColour, int> manaCost)
        {
            return $"The {cardType} {cardName} Has been Cast! with a ManaCost of: {manaCost}.";
        }
    }
}
