using System.Collections.Generic;
using NUnit.Framework;
using Santase.Logic;
using Santase.Logic.Cards;

namespace DeckTest
{
    /// <summary>
    /// Testing Deck.cs from ..\\..\\Task-2-Decks\\Santase.Logic.dll
    /// Link to tested class in repo: https://github.com/NikolayIT/SantaseGameEngine/blob/master/Source/Santase.Logic/Cards/Deck.cs
    /// </summary>

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void CheckIfDeckConstructorWorks()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck);
        }

        [Test]
        public void DeckTrumpCardShouldExist()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test]
        public void CheckIfCardsLeftIsCorrectValue()
        {
            var deck = new Deck();
            Assert.IsTrue(deck.CardsLeft >= 0 && deck.CardsLeft < 25);
        }

        [Test]
        [TestCase(2)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(18)]
        public void GetNextCardShouldWork(int testsCount)
        {
            var deck = new Deck();
            for (int i = 0; i < testsCount; i++)
            {
                Assert.IsNotNull(deck.GetNextCard());
            }
        }

        [Test]
        public void DeckShouldThrowIfCardsAreEmpty()
        {
            var deck = new Deck();

            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void ChangeTrumpCardShouldWork()
        {
            var deck = new Deck();
            var card = new Card(CardSuit.Diamond, CardType.Ten);
            deck.ChangeTrumpCard(card);
            Assert.IsTrue(deck.TrumpCard.Equals(card));
        }
    }
}
