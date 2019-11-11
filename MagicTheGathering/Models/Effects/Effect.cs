using System;

namespace MagicTheGathering.Models
{
    public class Effect
    {
        public static Func<HP, int, int> Burn { get; } = (healthPoints, burnvalue) => burnvalue - healthPoints.HealthPoints;

        public static Func<Card, int, string> Destruction { get; } = (card, value) => card.Destroy(value);

        public static Func<Card, string> POP { get; } = (card) => card.Destroy(1);

        public static Func<Effect, string> Negate { get; } = (effect) => Negation(effect);

        private static Func<string, string> DoNothing { get; } = (effect1) => "This is a Placeholder Effect";

        private static string Negation(Effect effect)
        {
            Spell.SpellEffect = DoNothing;
            return $"Effect {effect} has been Negated";
        }
    }
}