using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
    class Monster : Card
    {
        public int Attack { get; set; }

        public int Toughness { get; set; }

        public Monster (Dictionary<TerrainColour, int>  manaCost, string cardName, int attack, int toughness) : base(manaCost, cardName)
        {
            Attack = attack;
            Toughness = toughness;
        }
    }
}
