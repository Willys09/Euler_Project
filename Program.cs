﻿using System;
using Euler_Project.Problems;
using EulerProject.Data.Readers;

namespace Euler_Project
{
    public class Program
    {
        private static bool endApp = false;

        static public void Main(string[] args)
        {
            Console.WriteLine("Console App Used to Display Results of my Euler Project Code");
            Console.WriteLine("As long as the questions are simple enough, they will all show up here.");
            Console.WriteLine("------------------------------\n");

            while (!endApp)
            {
                Console.WriteLine("Option 1: Run Problem 1.");
                Console.WriteLine("Option 2: Run Problem 2.");
                Console.WriteLine("Option 3: Run Problem 3.");
                Console.WriteLine("Option 4: Run Problem 4.");
                Console.WriteLine("Option 5: Run Problem 5.");
                Console.WriteLine("Option 6: Run Problem 6.");
                Console.WriteLine("Option 7: Run Problem 7.");
                Console.WriteLine("Option 8: Run Problem 8.");
                Console.WriteLine("Option 9: Run Problem 9.");
                Console.WriteLine("\n");


                Console.Write("Press 'n' and Enter to close the app, or press # of option and Enter to continue: ");
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("\n\nCase 1:\n\n");
                        IProblem problem1 = new Problem1();
                        problem1.PrintProblem();
                        problem1.SolveProblem();
                        problem1.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "2":
                        Console.WriteLine("\n\nCase 2:\n\n");
                        IProblem problem2 = new Problem2();
                        problem2.PrintProblem();
                        problem2.SolveProblem();
                        problem2.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "3":
                        Console.WriteLine("\n\nCase 3:\n\n");
                        IProblem problem3 = new Problem3();
                        problem3.PrintProblem();
                        problem3.SolveProblem();
                        problem3.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "4":
                        Console.WriteLine("\n\nCase 4:\n\n");
                        IProblem problem4 = new Problem4();
                        problem4.PrintProblem();
                        problem4.SolveProblem();
                        problem4.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "5":
                        Console.WriteLine("\n\nCase 5:\n\n");
                        IProblem problem5 = new Problem5();
                        problem5.PrintProblem();
                        problem5.SolveProblem();
                        problem5.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "6":
                        Console.WriteLine("\n\nCase 6:\n\n");
                        IProblem problem6 = new Problem6();
                        problem6.PrintProblem();
                        problem6.SolveProblem();
                        problem6.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "7":
                        Console.WriteLine("\n\nCase 7:\n\n");
                        IProblem problem7 = new Problem7();
                        problem7.PrintProblem();
                        problem7.SolveProblem();
                        problem7.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "8":
                        Console.WriteLine("\n\nCase 8:\n\n");
                        IProblem problem8 = new Problem8();
                        problem8.PrintProblem();
                        problem8.SolveProblem();
                        problem8.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "9":
                        Console.WriteLine("\n\nCase 9:\n\n");
                        IProblem problem9 = new Problem9();
                        problem9.PrintProblem();
                        problem9.SolveProblem();
                        problem9.PrintAnswer();
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "10":
                        var reader = new PokerHandsReader();
                        reader.PrintLines();
                        break;
                    case "n":
                        endApp = true;
                        break;
                    default:
                        Console.WriteLine("Not an option.");
                        Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                        break;
                }
            }
            return;
        }
    }
}
