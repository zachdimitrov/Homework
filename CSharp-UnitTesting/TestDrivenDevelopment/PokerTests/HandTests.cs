using System;
using NUnit.Framework;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestFixture]
    // problem 2 - Hand
    public class HandTests
    {
        [Test]
        public void TestIfToStringDoesNotReturnNUll()
        {
            var cards = new List<ICard>();
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Three, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Four, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            var hand = new Hand(cards);
            var result = hand.ToString();
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestIfToStringReturnsCorrectValue()
        {
            var cards = new List<ICard>();
            cards.Add(new Card(CardFace.Two, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Three, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Four, CardSuit.Clubs));
            cards.Add(new Card(CardFace.Five, CardSuit.Clubs));
            var hand = new Hand(cards);
            var result = hand.ToString();
            Assert.IsNotNull(result);
            var expected = "Hand:\r\nTwo of Clubs\r\nThree of Clubs\r\nFour of Clubs\r\nFive of Clubs\r\n";
            Assert.AreEqual(expected, result);
        }
    }
}
