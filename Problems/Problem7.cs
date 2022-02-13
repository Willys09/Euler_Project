using System;

namespace Euler_Project.Problems
{
    /*
     * What is the 10001st prime number?
     */
    class Problem7 : IProblem
    {
        public long Answer { get; set; }

        public Problem7()
        {
            Answer = 0;
        }

        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("What is the 10 001st prime number?\n");
        }

        public void SolveProblem()
        {
            BruteForce(10001);
        }

        private void BruteForce(int nthPrime)
        {
            int numberToCheck = 2;
            int numberOfPrimes = 0;
            while(numberOfPrimes < nthPrime)
            {
                if(IsPrime(numberToCheck))
                {
                    numberOfPrimes++;
                }
                if(numberOfPrimes == nthPrime)
                {
                    Answer = numberToCheck;
                }
                numberToCheck++;
            }
        }

        private bool IsPrime(int numberToCheck)
        {
            for (int i = 2; i < numberToCheck; i++)
            {
                if(numberToCheck%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
