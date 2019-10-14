using System;

namespace MagicTheGathering
{
  class Monster : Card
  {

    public Static readonly string CardType {get; set;} = "Monster Card";

    public Monster(string manaCost, string cardName, Colour colour, int attack, int toughness)
    {
        ManaCost = manacost;
        CardName = cardName;
        Colour = colour;
        Attack = attack;
        Toughness = toughness;
    }

    public DamageOutput Attack()
    {

    }

  }

}
