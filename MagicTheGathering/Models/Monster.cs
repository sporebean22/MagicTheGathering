using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
  class Monster : Card
  {
    public override string CardType { get; } = "Monster Card";

    public virtual string Subtype {get; set;}

    public virtual int? Attack { get; set; }

    public virtual int? Toughness { get; set; }

    public Monster(int attack, int toughness, Dictionary<TerrainColour, int> manacost, string cardName, TerrainColour terrainColour) : base(manacost, cardName, terrainColour)
    {
        Attack = attack;
        Toughness = toughness;
    }

    /*public DamageOutput Attack(Target target)
    {
    }*/

  }

}
