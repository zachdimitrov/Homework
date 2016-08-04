using System;
using NUnit.Framework;
using ArmyOfCreatures.Logic;
using Moq;
using Moq.Protected;

namespace ArmyOfCreaturesTests
{
    [TestFixture]
    public class CreaturesFactoryTests
    {
        [TestCase("Angel")]
        [TestCase("Archangel")]
        [TestCase("ArchDevil")]
        [TestCase("Behemoth")]
        [TestCase("Devil")]
        public void CreaturesFactory_WhenValidNameIsPassed_ShouldReturnObject(string name)
        {
            var factory = new CreaturesFactory();

            var creature = factory.CreateCreature(name);

            Assert.AreEqual(name, creature.GetType().Name);
        }

        [Test]
        public void CreaturesFactory_WhenInValid_ShouldThrowArgumentException()
        {
            var factory = new CreaturesFactory();

            Assert.Throws<ArgumentException>(() => factory.CreateCreature("Gosho")); ;
        }

        [Test]
        public void CreaturesFactory_WhenInValid_ShouldThrowWithExpectedMessage()
        {
            var factory = new CreaturesFactory();
            try
            {
                factory.CreateCreature("Gosho");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid creature type \"Gosho\"!", ex.Message);
            }
        }
    }
}
