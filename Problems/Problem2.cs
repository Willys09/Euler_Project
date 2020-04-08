using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    /*
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
     * find the sum of the even-valued terms.
     */
    class Problem2
    {
        //Constants
        private const int Max = 4000000;
        
        //Local Fields
        public int Answer;


        //Constructors
        public Problem2()
        {
            Answer = 0;
            Fibonacci(1, 1);
        }


        //Get Methods
        public int GetAnswer()
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
            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million,  ");
            Console.WriteLine("find the sum of the even-valued terms.\n");
        }
        //Work Methods

        private void SolveProblem()
        {

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
