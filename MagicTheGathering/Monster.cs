using System;

namespace MagicTheGathering
{
  class Monster : Card
  {

    public static const string _cardType = "Monster Card";

    public virtual string Subtype {get; set;}

    public virtual int? Attack { get; set; }

    public virtual int? Toughness { get; set; }

    public Monster(string manaCost, string cardName, Colour colour, int attack, int toughness)
    {
        ManaCost = manacost;
        CardName = cardName;
        Colour = colour;
        Attack = attack;
        Toughness = toughness;
    }

    public DamageOutput Attack(Target target)
    {

    }

  }

}
