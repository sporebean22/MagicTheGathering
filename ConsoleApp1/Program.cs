using System;
using System.Collections.Generic;
using MagicTheGathering;
using MagicTheGathering.Models;

namespace MTGGame
{
    class Program
    {
        private static INarrator narrator = new Narrator();
        public static void Main()   
        {
            Console.WriteLine(narrator.GameBegin());
            Dictionary<TerrainColour, int> test = new Dictionary<TerrainColour, int>();
            Monster monster = new Monster(test, "BasicMonster1", TerrainColour.Red, 5,5);
            Console.WriteLine(narrator.NarrateBasicMonster(monster)); 
        }
    }
}
