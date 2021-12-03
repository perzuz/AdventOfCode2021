using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Challenges.Day1_SonarSweep
{
    public class SonarSweep
    {
        public SonarSweep(List<int> input)
        {
            m_input = input;
        }

        public int CalculateIncrease(int chunkSize)
        {
            int depthIncreaseCount = 0;
            var prevChunkSum = 0;

            for (int i = 1; i <= m_input.Count - chunkSize; i++)
            {
                prevChunkSum = m_input.GetRange(i - 1, chunkSize).Sum();
                var currentChunkSum = m_input.GetRange(i, chunkSize).Sum();

                if (currentChunkSum > prevChunkSum) depthIncreaseCount++;
            }

            return depthIncreaseCount;
        }

        private readonly List<int> m_input;
    }
}
