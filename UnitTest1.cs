using System;
using Quadrant;
using NUnit.Framework;

namespace QuandrantTest1
{
    [TestFixture]
    public class UnitTest1
    {
        private QuadrantCalculator quadrantCalculator;

        [OneTimeSetUp]
        public void OnTestStarted()
        {
            quadrantCalculator = new QuadrantCalculator();
        }
        [Test]
        public void TestQuadrant1()
        {
            int x = 4;
            int y = 1;

            string acualQuadrant = quadrantCalculator.DefinitionQuadrant(x, y);

            string expectedQuadrant = "quadrant1";
            Assert.AreEqual(expectedQuadrant, acualQuadrant);

        }
        [TestCase(-2, 3, "quadrant2")]
        [TestCase(-2, -3, "quadrant3")]
        [TestCase(2, -3, "quadrant4")]
        [TestCase(0, 3, "quadrant1")]
        [TestCase(-2, 0, "quadrant2")]
        [TestCase(0, 0, "quadrant1")]
        public void TestQuadrant(int x, int y, string expectedQuandrante)
        {

            string acualQuadrant = quadrantCalculator.DefinitionQuadrant(x, y);

            Assert.AreEqual(expectedQuandrante, acualQuadrant);

        }
    }
}
