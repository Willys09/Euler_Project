using System;

namespace Euler_Project.Problems
{
    /*
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     * find the sum of the even-valued terms.
     */
    class Problem2 : IProblem
    {
        //Constants
        private const int Max = 4000000;
        
        //Local Fields
        public long Answer { get; set; }

        //Constructors
        public Problem2()
        {
            Answer = 0;
        }

        //Get Methods
        public void PrintAnswer()
        {
            Console.WriteLine("The answer to the problem is: " + Answer);
        }

        public void PrintProblem()
        {
            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million,  ");
            Console.WriteLine("find the sum of the even-valued terms.\n");
        }

        //Work Methods
        public void SolveProblem()
        {
            Fibonacci(1, 1);
        }

        private void Fibonacci(int number1, int number2)
        {
            if(number1%2 == 0)
            {
                Answer += number1;
            }
            if (number2 < Max)
            {
                Fibonacci(number2, number1 + number2);
            }
        }
    }
}
