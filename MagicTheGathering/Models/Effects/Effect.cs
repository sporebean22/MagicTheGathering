using System;

namespace MagicTheGathering.Models
{
    public class Effect
    {
        public static Func<HP, int, int> Burn { get; } = (healthPoints, burnvalue) => burnvalue - healthPoints.HealthPoints;

        //public static Func<Card, int, string> Destruction { get; } = (card, value) => card.Destroy(value);

        //public static Func<Card> POP { get; } = (card) => card.Destroy(1);

        //public Func<Effect, string> Negate { get; } = (effect) => Negation(effect);

        private Func<string, string> DoNothing { get; } = (effect1) => "This is a Placeholder Effect";

        private Func<Target, string> Trample { get; } = (target) => "work on this";

        private Func<Target, string> Flying { get; } = (target) => "work on this";

        private Func<Target, string> Haste { get; } = (target) => "work on this";

        private Func<Target, string> Hexproof { get; } = (target) => "work on this";

        private Func<Target, string> Indestructible { get; } = (target) => "work on this";

        public string currentEffect {get; set;}

        public Effect(string effect)
        {
            currentEffect = effect;
        }

        private string Negation(Effect effect)
        {
            //effect = DoNothing;
            return $"Effect {effect} has been Negated";
        }
    }
}
