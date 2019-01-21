using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowling
{
    class ScoreCalculator
    {
        public static void CalculateScore(Frame[] frames)
        {
            int totalScore = 0;

            foreach (Frame frame in frames)
            {
                totalScore += frame.Score;
            }

            Console.WriteLine("total score is:  {0}", totalScore);
        }
    }
}
