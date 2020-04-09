using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    /*
     * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
     * Find the product abc.
     */
    class Problem9 : IProblem
    {
        private int a;
        private int b;
        private int c;

        public long Answer { get; set; }

        public Problem9()
        {
            Answer = 0;
        }
        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.\n");
        }

        public void SolveProblem()
        {
            BruteForce(1000);
        }

        private void BruteForce(int sumRequired)
        {
            for(int i = 1; i < sumRequired; i++)
            {
                for(int j = i + 1; j < sumRequired; j++)
                {
                    int tempA = i;
                    int tempB = j;
                    int tempC = sumRequired - i - j;
                    if(tempB >= tempC)
                    {
                        break;
                    }
                    if(tempA * tempA + tempB * tempB == tempC * tempC)
                    {
                        Answer = tempA * tempB * tempC;
                        return;
                    }
                }
            }
        }
    }
}
