using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var values = hand.Cards;
            if (hand.Cards.Count != 5)
            {
                return false;
            }
            return values.All(x => values.Count(y => (x.Face == y.Face && x.Suit == y.Suit)) == 1);
        }

        public bool IsStraightFlush(IHand hand)
        {
            return IsFlush(hand) && IsStraight(hand);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var values = hand.Cards;
            int maxCount = 1;
            for (int i = 0; i < values.Count; i++)
            {
                int counter = 1;
                for (int j = 0; j < values.Count; j++)
                {
                    if (values[i].Face == values[j].Face && i != j)
                    {
                        counter++;
                    }
                }

                if (counter > maxCount)
                {
                    maxCount = counter;
                }
            }
            return maxCount == 4;
            //return values.All(x => values.Count(y => (x.Face == y.Face)) == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            var cards = hand.Cards;
            var firstCard = cards[0].Suit; 
            for (int i = 1; i < cards.Count; i++)
            {
                if ((int)cards[i].Suit != (int)firstCard)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsFlush(IHand hand)
        {
            var values = hand.Cards;
            var currentSuit = values[0].Suit;
            for (int i = 1; i < values.Count; i++)
            {
                if ((int)values[i].Suit != (int)currentSuit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStraight(IHand hand)
        {
            var cards = hand.Cards;
            cards = cards.OrderBy(x => x.Face).ToList();
            for (int i = 0; i < cards.Count - 1; i++)
            {
                if ((int)cards[i + 1].Face - (int)cards[i].Face != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var values = hand.Cards;
            var query = values.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();
            return (query.Count == 1 && query[0].Counter == 3);
        }

        public bool IsTwoPair(IHand hand)
        {
            var values = hand.Cards;
            var query = values.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();
            return (query.Count == 2 && query[0].Counter == 2 && query[1].Counter == 2);
        }

        public bool IsOnePair(IHand hand)
        {
            var values = hand.Cards;
            var query = values.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() })
              .ToList();
            return (query.Count == 1 && query[0].Counter == 2);
        }

        public bool IsHighCard(IHand hand)
        {
            return !IsStraight(hand) &&
                !IsStraightFlush(hand) &&
                !IsThreeOfAKind(hand) &&
                !IsTwoPair(hand) &&
                !IsFlush(hand) &&
                !IsFourOfAKind(hand) &&
                !IsFullHouse(hand) &&
                !IsOnePair(hand);
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
