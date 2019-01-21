using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenPinBowling
{
    class UserInput
    {
        public static Frame[] GetFrames()
        {
            // create an array of objects
            Frame[] frames = new Frame[3];

            for (int frameNumber = 0; frameNumber < 3; frameNumber++)
            {
                Console.WriteLine("Frame : {0}", frameNumber + 1);
                Console.WriteLine();

                Console.Write("enter score for first delivery: ");

                string inputOne = Console.ReadLine();
                try
                {
                    int firstScore = Convert.ToInt32(inputOne);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }

                Console.Write("enter score for second delivery: ");

                string inputTwo = Console.ReadLine();
                try
                {
                    int secondScore = Convert.ToInt32(inputTwo);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Input string is not a sequence of digits.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }

                Frame frame = new Frame(firstScore, secondScore);
                frames[frameNumber] = frame;
                Console.WriteLine();
            }
            return frames;
        }
    }
}
