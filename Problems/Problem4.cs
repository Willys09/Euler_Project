using System;
using System.Collections.Generic;
using System.Text;

namespace Euler_Project.Problems
{
    /*
    * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    * Find the largest palindrome made from the product of two 3-digit numbers.
    */

    class Problem4
    {
        //Local Fields
        public long Answer;
        public int MultiplierAnswer;
        public int MultiplicandAnswer;


        public Problem4()
        {
            Answer = 0;
            MultiplierAnswer = 0;
            MultiplicandAnswer = 0;
            BruteForce();
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
            Console.WriteLine("Using " + MultiplierAnswer + " and " + MultiplicandAnswer + " as multipliers");
        }
        private void WriteProblem()
        {
            Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers.\n");
        }

        //Worker Methods
        private void BruteForce()
        {
            for(int i = 999; i > 100; i--)
            {
                for(int j = 999; j > 100; j-- )
                {
                    long result = i * j;
                    if(IsPalindrome(result))
                    {
                        if(result > Answer)
                        {
                            Answer = result;
                            MultiplierAnswer = i;
                            MultiplicandAnswer = j;
                        }
                    }
                }
            }

        }

        private bool IsPalindrome(long numberToCheck)
        {
            bool result = false;
            string numberString = numberToCheck.ToString();
            char[] reverseCharArray = new char[numberString.Length];


            for (int i = 0; i <= numberString.Length / 2; i++)
            {
                char leftDigit = numberString[i];
                char rightDigit = numberString[numberString.Length - i - 1];
                reverseCharArray[i] = rightDigit;
                reverseCharArray[numberString.Length - i - 1] = leftDigit;
            }

            string reverseString = new string(reverseCharArray);
            if (string.Equals(reverseString, numberString))
            {
                result = true;
            }
            return result;
        }
    }
}
