using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    public class Card : ICard
    {
        public virtual string ManaCost { get; set; }

        public virtual string CardName { get; set; }

        public virtual Colour Colour { get; set; }

        public virtual int? Attack { get; set; }

        public virtual int? Toughness { get; set; }

        public Card
        (
          string manaCost,
          string cardName,
          Colour colour,
          int attack,
          int toughness
        )
        {
          Manacost = manaCost ?? throw new ArgumentNullException(nameof(manaCost));
          CardName = cardName ?? throw new ArgumentNullException(nameof(cardName));
          Colour = colour ?? throw new ArgumentNullException(nameof(colour));
          Attack = attack ?? throw new ArgumentNullException(nameof(attack));
          Toughness = tougness ?? throw new ArgumentNullException(nameof(tougness));
        }
    }
}
