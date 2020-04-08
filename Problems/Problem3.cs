using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    class Problem3
    {
        /*
        *The prime factors of 13195 are 5, 7, 13 and 29.
        * What is the largest prime factor of the number 600851475143 ?
        */


        //Constants
        private const long NumberIn = 600851475143;
        //Local Fields
        public long Answer;

        public Problem3()
        {
            Answer = 0;
            RecursiveSolve(NumberIn);
            PrintAnswer();
        }

        //Getter Methods
        public long GetAnswer()
        {
            return Answer;
        }

        public void PrintAnswer()
        {
            WriteProblem();
            Console.WriteLine("The answer to the problem is: " + Answer);
        }
        private void WriteProblem()
        {
            Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29.");
            Console.WriteLine("What is the largest prime factor of the number 600851475143?\n");
        }

        //Worker Methods

        private void RecursiveSolve(long numberIn)
        {
            //If we get to the end of this for loop than the number is a prime number
            for (int i = 2; i < numberIn / 2; i++)
            {
                if (numberIn % i == 0)
                {
                    //Than we found something that divides the number
                    //And we need to find both numbers prime factors
                    RecursiveSolve(i);
                    RecursiveSolve(numberIn / i);
                    // The number given isn't a prime, so we are done with it
                    return;
                }
            }
            Console.WriteLine(numberIn);
            if (numberIn > Answer)
            {
                Answer = numberIn;
            }

        }
    }
}
