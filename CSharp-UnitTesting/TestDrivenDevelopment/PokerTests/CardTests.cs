using System;
using NUnit.Framework;
using Poker;

namespace PokerTests
{
    [TestFixture]
    // problem 1 - Card
    public class CardTests
    {
        [Test]
        public void CheckIfToStringReturnsValue()
        {
            var card = new Card(CardFace.Two, CardSuit.Clubs);
            var result = card.ToString();
            Assert.IsNotNull(result);
        }

        [Test]
        public void CardConstructorShouldReturnCorrectValue()
        {
            var card = new Card(CardFace.Ace, CardSuit.Spades);
            var result = card.ToString();
            Assert.AreEqual("Ace of Spades", result);
        }
    }
}
