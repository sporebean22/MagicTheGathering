using System;

namespace MagicTheGathering.Models
{
    public class Effect
    {
        public static Func<HP, int, int> Burn = (healthPoints, burnvalue) => burnvalue - healthPoints.HealthPoints;

        public static Func<Card, int, string> Destruction = (card, value) => card.Destroy(value);

        public static Func<Card, string> POP = (card) => card.Destroy(1);

        public static Func<Effect, string> Negate = (effect) => effect.Negation();

        private Func<Spell> DoNothing = (effect1) => (effect1);

        private string Negation(this Effect effect)
        {
            Spell.SpellEffect = 

                return "3";
        }
            
    }
}