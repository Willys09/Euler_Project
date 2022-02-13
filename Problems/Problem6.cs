using System;

namespace Euler_Project.Problems
{
    /*
    * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
    */
    class Problem6 : IProblem
    {

        private long SumOfTheSquares;
        private long SquareOfTheSums;
        public long Answer { get; set; }

        public Problem6()
        {
            Answer = 0;
            SumOfTheSquares = 0;
            SquareOfTheSums = 0;
        }

        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.\n");
        }

        public void SolveProblem()
        {
            BruteForce(100);
        }

        private void BruteForce(int numberOfTerms)
        {
            int sum = 0;
            for (int i = 1; i <= numberOfTerms; i++)
            {
                SumOfTheSquares += i * i;
                sum += i;
            }
            SquareOfTheSums = sum * sum;

            //Difference
            Answer = Math.Abs(SumOfTheSquares - SquareOfTheSums);
        }
    }
}
