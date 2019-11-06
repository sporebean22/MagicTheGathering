using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering.Models
{
    class Spell : Card
    {
        public override string CardType { get; } = "Spell";

        public static Delegate SpellEffect { get; set; }

        public Spell(Delegate effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(manaCost, cardName, terrainColour)
        {
            SpellEffect = effect;
            Console.WriteLine(Narrator.NarrateSpellBasic(CardType, CardName, manaCost));
        }
    }
}
