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

        public int CalculateDepthIncrease()
        {
            int depthIncreaseCount = 0;

            for (int i = 0; i < m_input.Count; i++)
            {
                if (i == 0) continue;

                var prevDepth = m_input[i - 1];
                var currentDepth = m_input[i];

                if (currentDepth > prevDepth)
                {
                    depthIncreaseCount++;
                }

            }

            return depthIncreaseCount;
        }

        public int CalculateSlidingWindowDepthIncrease()
        {
            int depthIncreaseCount = 0;

            for (int i = 0; i < m_input.Count - 2; i++)
            {
                if (i == 0) continue;

                var prevChunkSum = m_input.GetRange(i - 1, 3).Sum();
                var currentChunkSum = m_input.GetRange(i, 3).Sum();

                if (currentChunkSum > prevChunkSum)
                {
                    depthIncreaseCount++;
                }
            }

            return depthIncreaseCount;
        }

        private readonly List<int> m_input;
    }
}
