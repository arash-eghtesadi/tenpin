﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ten Pin Bowling";
            Frame[] frames = UserInput.GetFrames();
            ScoreCalculator.CalculateScore(frames);
        }
    }
}
