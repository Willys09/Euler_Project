using System;

namespace Euler_Project.Problems
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
     * The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    public class Problem1 : IProblem
    {
        //Constants
        public const int Max = 1000;

        //Local Fields
        public long Answer { get; set; }

        //Constructors
        public Problem1()
        {
            Answer = 0;
        }

        //Getter Methods
        public long GetAnswer()
        {
            return Answer;
        }

        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. ");
            Console.WriteLine("The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.\n");
        }

        //Work Methods
        public void SolveProblem()
        {
            long result = 0;

            for(int i = 0; i < Max; i++)
            {
                //Check if the number is divisible by 3
                //If it is, add it to them sum.
                if(i%3 == 0)
                {
                    result += i;
                }
                //Else if the number is divisible by 5
                //Add it to the sum. 
                //Assumes we do not double add if the number divideds by 3 and 5
                else if(i%5 == 0)
                {
                    result += i;
                }
            }
            Answer = result;
        }
    }
}
