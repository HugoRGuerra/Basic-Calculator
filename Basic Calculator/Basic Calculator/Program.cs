using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable to indicate if the user wants the program running or not
            bool exit = false;

            while (exit == false) // While the user wants the program running
            {
                // Variables to save the
                double num1; // First number
                double num2; // Second number
                string input; // Option chosen by the user

                Console.Clear(); // Clears console 

                Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
                Console.Write("Please insert first number: "); // Asks for the first number
                Console.ForegroundColor = ConsoleColor.Green; // Text Color
                num1 = Convert.ToDouble(Console.ReadLine()); // Saves first number into num1 variable
                Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
                Console.Write("Please insert second number: "); // Asks for the second number
                Console.ForegroundColor = ConsoleColor.Green; // Text Color
                num2 = Convert.ToDouble(Console.ReadLine()); // Saves second number into num2 variable

                Console.Clear(); // Clears console

                Menu(); // Displays Menu
                Console.ForegroundColor = ConsoleColor.Green; // Text Color
                input = Console.ReadLine(); // Saves the option chosen by the user into input variable
                Console.Clear(); // Clears console

                switch (input) // Executes from a list of options based on the user's input 
                {
                    // SUM
                    case "+": 
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(SUM(num1, num2));
                        Console.ReadKey();
                        break;

                    // SUBTRACTION
                    case "-":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(SUBTRACTION(num1, num2));
                        Console.ReadKey();
                        break;

                    // MULTIPLY
                    case "*":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(MULTIPLY(num1, num2));
                        Console.ReadKey();
                        break;

                    // DIVIDE
                    case "/":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Result: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(DIVIDE(num1, num2));
                        Console.ReadKey();
                        break;
    
                    // DISPLAYS INFO ABOUT THE APP
                    case "About":
                        About();
                        break;

                    // QUIT APP
                    case "Exit":
                        exit = true;
                        break;
                    
                    // INVALID OPTION
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }

            Environment.Exit(0); // Quits the Application
        }

        public static void Menu() // Function to display Menu
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
            Console.WriteLine("Select one of the options:"); // Helpfull Text
            Console.WriteLine("--"); // Separator
            Console.ForegroundColor = ConsoleColor.DarkYellow; // Text Color
            Console.WriteLine("     +"); // SUM Option
            Console.ForegroundColor = ConsoleColor.Magenta; // Text Color
            Console.WriteLine("     -"); // SUBTRACTION Option
            Console.ForegroundColor = ConsoleColor.White; // Text Color
            Console.WriteLine("     *"); // MULTIPLY Option
            Console.ForegroundColor = ConsoleColor.Blue; // Text Color
            Console.WriteLine("     /"); // DIVIDE Option
            Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
            Console.WriteLine(); // Skip a line (Space)
            Console.Write("Type ");
            Console.ForegroundColor = ConsoleColor.Green; // Text Color
            Console.Write("'About'");
            Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
            Console.Write(" to know more");
            Console.WriteLine();
            Console.Write("Type ");
            Console.ForegroundColor = ConsoleColor.Red; // Text Color
            Console.Write("'Exit'");
            Console.ForegroundColor = ConsoleColor.Cyan; // Text Color
            Console.Write(" to quit");
            Console.WriteLine();
            Console.WriteLine("--"); // Separator
        }
        public static void About()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       About this Basic Calculator");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("With this program you can:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  + : SUM");
            Console.WriteLine("  - : SUBTRACT");
            Console.WriteLine("  * : MULTIPLY");
            Console.WriteLine("  / : DIVIDE");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("It is very simple to use! Enjoy.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("This program was made by Hugo Guerra, a portuguese teenager that likes");
            Console.WriteLine("programming litle programs. He thinks that is fun to program and he is");
            Console.WriteLine("learning more and more every day. Soon he will achieve a lot, he hopes");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("github.com/HugoRGuerra");
            Console.ReadKey();
        }
        public static double SUM(double num1, double num2)
        {
            return num1 + num2;
        }  // SUM Calculation
        public static double SUBTRACTION(double num1, double num2)
        {
            return num1 - num2;
        } // SUBTRACTION Calculation
        public static double MULTIPLY(double num1, double num2)
        {
            return num1 * num2;
        } // MULTIPLY Calculation
        public static double DIVIDE(double num1, double num2)
        {
            return num1 / num2;
        } // DIVIDE Calculation
    }
}
