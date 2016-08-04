using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine("Hand:");
            foreach (var card in this.Cards)
            {
                str.AppendLine(string.Format("{0} of {1}", card.Face, card.Suit));
            }
            return str.ToString();
        }
    }
}
