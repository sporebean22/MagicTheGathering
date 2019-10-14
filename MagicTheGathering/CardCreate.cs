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

    }
}
