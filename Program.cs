using System;

namespace Euler_Project
{
    class Program
    {

        private static bool endApp = false;


        static void Main(string[] args)
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
                Console.WriteLine("\n");


                Console.Write("Press 'n' and Enter to close the app, or press # of option and Enter to continue: ");
                string caseSwitch = Console.ReadLine();

                switch (caseSwitch)
                {
                    case "1":
                        Console.WriteLine("\n\nCase 1:\n\n");
                        
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "2":
                        Console.WriteLine("\n\nCase 2:\n\n");
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "3":
                        Console.WriteLine("\n\nCase 3:\n\n");                   
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "4":
                        Console.WriteLine("\n\nCase 4:\n\n");
                        Console.WriteLine("------------------------------\n");
                        break;
                    case "5":
                        Console.WriteLine("\n\nCase 5:\n\n");
                        Console.WriteLine("------------------------------\n");
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
