using System;

namespace MagicTheGathering.Models
{
    public class Effect
    {
        public static Func<HP, int, int> Burn = (healthPoints, burnvalue) => burnvalue - healthPoints.HealthPoints;

        public static Func<Card, int, string> Destruction = (card, value) => card.Destroy(value);

        public static Func<Card, string> POP = (card) => card.Destroy(1);

        public static Func<Effect, string> Negate = (effect) => Negation(effect);

        private static Func<string, string> DoNothing = (effect1) => "Hi";

        private static string Negation(Effect effect)
        {
            Spell.SpellEffect = DoNothing;
            return $"Effect {effect} has been Negated";
        }
    }
}