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
            var IronForgeManaCost = new Dictionary<TerrainColour, int>();
            var monster = new Monster(IronForgeManaCost, "Dragon of the Iron Forge", MonsterType.Dragon ,TerrainColour.Red, 5,5);
            Console.WriteLine(narrator.NarrateBasicMonster(monster)); 
        }
    }

    public sealed class Game
    {
        public Monster Monster { get; set; }
        public Spell Spell { get; set; }
        public Instant Instant { get; set; }
        public Sorcery Sorcery { get; set; }

        public void Cast(Monster monster)
        {
            Monster = monster;
        }

        public void GetHand()
        { }
    }
}
