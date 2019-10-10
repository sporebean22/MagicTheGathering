using System;
using System.Collections.Generic;
using MagicTheGathering;

namespace MagicVisioUI
{
    class Program
    {
        public Dictionary<TerrainColour, int> test = new Dictionary<TerrainColour, int>();

        static void Main(string[] args)
        {
            var dictionary = new Dictionary<TerrainColour, int>()
            {
                {TerrainColour.Colourless, 2},
                {TerrainColour.Blue, 2}
            };

            dictionary[TerrainColour.Black] = 4;
            dictionary.Add(TerrainColour.Green, 5);

            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine($"Mana Cost of {keyValuePair.Key} {keyValuePair.Value}");
            }
        }
    }
}
