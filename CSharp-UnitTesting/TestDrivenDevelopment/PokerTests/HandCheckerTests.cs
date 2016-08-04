using System;
using NUnit.Framework;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestFixture]
    // problem 3 - IsValidHand(IHand)
    public class HandCheckerTests
    {
        [Test]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = false)]
        [TestCase(5, ExpectedResult = true)]
        [TestCase(8, ExpectedResult = false)]
        [TestCase(22, ExpectedResult = false)]
        public bool CheckIfHandCheckerFindsCorrectNumberOfCards(int a)
        {
            var cards = new List<ICard>();
            int faceNumber = 2;
            for (int i = 0; i < a; i++)
            {
                cards.Add(new Card((CardFace)faceNumber, CardSuit.Clubs));
                faceNumber ++;
            }
            var hand = new Hand(cards);
            var checker = new PokerHandsChecker();
            return checker.IsValidHand(hand);
        }

        [Test]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        public bool HandCheckerShouldCheckThatCardsAreDifferent(int t)
        {
            var newCards = new List<ICard>();
            int faceNumber = 2;
            if (t == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    newCards.Add(new Card((CardFace)faceNumber, CardSuit.Clubs));
                }
            }
            else if (t == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    newCards.Add(new Card((CardFace)faceNumber, CardSuit.Clubs));
                    faceNumber ++;
                }
            }
            var newHand = new Hand(newCards);
            var checker = new PokerHandsChecker();
            return checker.IsValidHand(newHand);
        }

        // problem 4 - IsFlush(IHand)
        [Test]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = false)]
        public bool HandCheckerShouldReturnTrueIfHandIsFlush(int t)
        {
            var flushCards = new List<ICard>();
            int faceNumber = 2;
            int suitNumber = 1;
            if (t == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    flushCards.Add(new Card((CardFace)faceNumber, CardSuit.Clubs));
                    faceNumber++;
                }
            }
            else if (t == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    flushCards.Add(new Card((CardFace)faceNumber, (CardSuit)suitNumber));
                    faceNumber++;
                    suitNumber++;
                    if (suitNumber > 4)
                    {
                        suitNumber = 1;
                    }
                }
            }
            var newHand = new Hand(flushCards);
            var checker = new PokerHandsChecker();
            return checker.IsFlush(newHand);
        }

        // problem 5 - IsFourOfAKind(IHand)
        [Test]
        [TestCase(0, ExpectedResult = true)]
        [TestCase(1, ExpectedResult = false)]
        public bool IsFourOfAKindShouldReturnTrueIfConditionIsMet(int t)
        {
            var kindCards = new List<ICard>();
            int faceNumber = 2;
            int suitNumber = 1;
            if (t == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    kindCards.Add(new Card((CardFace)faceNumber, (CardSuit)suitNumber));
                    suitNumber++;
                    if (suitNumber > 4)
                    {
                        suitNumber = 1;
                        faceNumber++;
                    }
                }
            }
            else if (t == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    kindCards.Add(new Card((CardFace)faceNumber, (CardSuit)suitNumber));
                    faceNumber++;
                    suitNumber++;
                    if (suitNumber > 4)
                    {
                        suitNumber = 1;
                    }
                }
            }
            var newHand = new Hand(kindCards);
            var checker = new PokerHandsChecker();
            return checker.IsFourOfAKind(newHand);
        }

        // problem 6.1 - IsHighCard(IHand hand)
        [Test]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        public bool IsHighCardShouldReturnTrueIfCardIsHigh(int t)
        {
            var highCards = new List<ICard>();
            int faceNumber = 2;
            int suitNumber = 1;
            if (t == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    highCards.Add(new Card((CardFace)faceNumber, (CardSuit)suitNumber));
                    suitNumber++;
                    if (suitNumber > 4)
                    {
                        suitNumber = 1;
                        faceNumber++;
                    }
                }
            }
            else if (t == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    highCards.Add(new Card((CardFace)faceNumber, (CardSuit)suitNumber));
                    faceNumber+=2;
                    suitNumber++;
                    if (suitNumber > 4)
                    {
                        suitNumber = 1;
                    }
                }
            }
            var newHand = new Hand(highCards);
            var checker = new PokerHandsChecker();
            return checker.IsHighCard(newHand);
        }
    }
}
