using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    public abstract class Spell : Card
    {
        private INarrator narrator;
        public static Delegate SpellEffect { get; set; }

        public Spell(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(manaCost, cardName, terrainColour)
        {
            SpellEffect = effect;
            ManaCost = manaCost;
            CardName = cardName;
            TerrainColour = terrainColour;
            Console.WriteLine(narrator.NarrateSpellBasic(this));
        }
    }
}
