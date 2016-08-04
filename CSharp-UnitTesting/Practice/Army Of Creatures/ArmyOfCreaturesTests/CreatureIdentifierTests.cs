using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreaturesTests
{
    [TestFixture]
    class CreatureIdentifierTests
    {
        [Test]
        public void WhenNullIsPassed_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => CreatureIdentifier.CreatureIdentifierFromString(null));
        }

        [Test]
        public void WhenInvalidValueIsPassed_ShouldThrowException()
        {
            Assert.Throws<FormatException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel(test)"));
        }

        [Test]
        public void WhenInvalidValueToParseIntIsPassed_ShouldThrowException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel5"));
        }

        [Test]
        public void WhenValidValueToParseIntIsPassed_ShouldReturnExpectedType()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.IsInstanceOf<CreatureIdentifier>(identifier);
        }

        [Test]
        public void WhenValidValueToParseIntIsPassed_ShouldReturnExpectedCreatureType()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel", identifier.CreatureType);
        }

        [Test]
        public void WhenValidValueToParseIntIsPassed_ShouldReturnExpectedArmyNumber()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual(1, identifier.ArmyNumber);
        }

        [Test]
        public void WhenValidValueToParseIntIsPassed_ToStringShouldReturnExpected()
        {
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            Assert.AreEqual("Angel(1)", identifier.ToString());
        }
    }
}
