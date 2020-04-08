using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
     * The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    public class Problem1
    {
        //Constants
        public const int Max = 1000;

        //Local Fields
        public int Sum;

        //Constructors
        public Problem1()
        {
            WriteProblem();
            Sum = SolveProblem(Max);
        }


        //Getter Methods
        public int GetSum()
        {
            return Sum;
        }


        //Work Methods
        private int SolveProblem(int maxIn)
        {
            int result = 0;

            for(int i = 0; i < maxIn; i++)
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
            return result;
        }

        public void WriteProblem()
        {
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. ");
            Console.WriteLine("The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
        }

    }
}
