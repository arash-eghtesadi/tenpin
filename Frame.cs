using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowling
{
    class Frame
    {
        private int firstScore;
        private int secondScore;

        public int FirstScore
        {
            get { return firstScore; }
            set { firstScore = value; }
        }

        public int SecondScore
        {
            get { return secondScore; }
            set { secondScore = value; }
        }

        public int Score
        {
            get
            {
                return (firstScore + secondScore);
            }
        }

        public bool Spare
        {
            get
            {
                return (firstScore + secondScore == 10);
            }
        }

        public bool Strike
        {
            get
            {
                return (firstScore == 10);
            }
        }

        // constructor
        public Frame(int firstScore, int secondScore)
        {
            this.firstScore = firstScore;
            this.secondScore = secondScore;
        }
    }
}
