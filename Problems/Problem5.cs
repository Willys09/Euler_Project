using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    /*
    * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
    class Problem5 : IProblem
    {
        public long Answer { get; set; }

        public Problem5()
        {
            Answer = 0;
        }
        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?\n");
        }

        public void SolveProblem()
        {
            BruteForce();
        }

        private void BruteForce()
        {
            int current = 40;
            while(Answer == 0)
            {
                if(current%20 == 0 && current%19 == 0 && current%18 == 0 && current%17 == 0 && current%16 == 0 && 
                    current%15 == 0 && current%14 == 0 && current%13 == 0 && current%12 == 0 && current%11 == 0)
                {
                    Answer = current;
                }
                current += 20;
            }
        }
    }
}
