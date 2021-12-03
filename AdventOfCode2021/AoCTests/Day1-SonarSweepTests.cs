using System.Collections.Generic;
using AdventOfCode2021.Challenges.Day1_SonarSweep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoCTests
{
    [TestClass]
    public class SonarSweepTests
    {
        [TestMethod]
        public void DepthIncreasesTenTimes_OutputIsTen()
        {
            var input = new List<int>()
            {
                1,2,1,3,4,5,6,5,4,5,6,7,8,9,3
            };

            var expected = 10;

            SonarSweep sonarSweep = new SonarSweep(input);

            var actual = sonarSweep.CalculateIncrease(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SlidingWindowDepth_OutputIs8()
        {
            var input = new List<int>()
            {
                1,2,1,2,2,2,1,1,1,2,2,2,3,3,3
            };

            var expected = 8;

            SonarSweep sonarSweep = new SonarSweep(input);

            var actual = sonarSweep.CalculateIncrease(3);

            Assert.AreEqual(expected, actual);
        }
    }
}
