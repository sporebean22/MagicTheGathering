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

        public Func<Effect> Effect { get; set; }

        public Spell(Func<Effect> effect, Dictionary<TerrainColour, int> manaCost, string cardName, TerrainColour terrainColour) : base(manaCost, cardName, terrainColour)
        {
            Effect = effect;
            Console.WriteLine(Narrator.NarrateSpellBasic(CardType, CardName, manaCost));
        }
    }
}
