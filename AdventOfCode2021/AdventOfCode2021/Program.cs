using AdventOfCode2021.Challenges.Day1_SonarSweep;
using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"D:\Programming\GitHub\AdventOfCode2021\AdventOfCode2021\AdventOfCode2021\Challenges\Day1-SonarSweep\Input\Day1Input.txt";
            var inputContent = File.ReadAllLines(inputFile);

            var sonarInput = inputContent.Select(x => Int32.Parse(x)).ToList();

            SonarSweep sonar = new SonarSweep(sonarInput);

            Console.WriteLine(sonar.CalculateSlidingWindowDepthIncrease());
            Console.Read();
        }
    }
}
