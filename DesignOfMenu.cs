
using System;
using CalculatorProject.utility;

namespace MathOperation
{
    class DesignOfMenu
    {
        static private int numberOfChooise = 0;

        static private void AdditionScreen()
        {

            Console.Clear();

            Console.WriteLine("\t\t\t\t < - - Welcome to Addition operation - - >\n\n");

            int number = OperationLogic.Addition("\t Enter number1 > ", "\t Enter number2 > ");
            Console.WriteLine($"\t Result is: {number}");

            Console.Write("\n\t > Press any key to go back...");
            Console.ReadKey();

        }

        static private void SubtractionScreen()
        {

            Console.Clear();

            Console.WriteLine("\t\t\t\t < - - Welcome to Subtraction operation - - >\n\n");

            int number = OperationLogic.Subtraction("\t Enter number1 > ", "\t Enter number2 > ");
            Console.WriteLine($"\t Result is: {number}");

            Console.Write("\n\t > Press any key to go back...");
            Console.ReadKey();

        }

        static private void MultiplicationScreen()
        {

            Console.Clear();

            Console.WriteLine("\t\t\t\t < - - Welcome to Multiplication operation - - >\n\n");

            int number = OperationLogic.Multiplication("\t Enter number1 > ", "\t Enter number2 > ");
            Console.WriteLine($"\t Result is: {number}");

            Console.Write("\n\t > Press any key to go back...");
            Console.ReadKey();

        }

        static private void DivisionScreen()
        {

            Console.Clear();

            Console.WriteLine("\t\t\t\t < - - Welcome to Division operation - - >\n\n");

            Console.WriteLine("\t warning: Can`t make operation if result not integer.");
            int number = OperationLogic.Division("\t Enter number1 > ", "\t Enter number2 > ");
            Console.WriteLine($"\t Result is: {number}");

            Console.Write("\n\t > Press any key to go back...");
            Console.ReadKey();

        }

        static private void ShowPreviousResultScreen()
        {
            Console.Clear();

            Console.WriteLine("\t\t\t\t < - - Welcome to Previous Result Screen - - >\n\n");

            List<string> result = OperationLogic.GetResult();

            foreach(string item in result)
            {

                Console.WriteLine($"\t {item}");
            }

            Console.Write("\n\t > Press any key to go back...");
            Console.ReadKey();

        }



        static private void HeaderScreen()
        {

            Console.WriteLine("\t\t\t\t < - - Welcome to math operation - - >\n\n");

        }

        static private void OptionsScreen()
        {

            Console.WriteLine("\t\t\t\t     [1] Addition              (+)");
            Console.WriteLine("\t\t\t\t     [2] Subtraction           (-)");
            Console.WriteLine("\t\t\t\t     [3] Multiplication        (*)");
            Console.WriteLine("\t\t\t\t     [4] Division              (/)");
            Console.WriteLine("\t\t\t\t     [5] Show previous result.");
                                          
            Console.WriteLine("\t\t\t\t     ------------------------------");

            numberOfChooise = ReadInput.ReadNumberBetweenRange("\t\t\t\t      Enter your chooises: ", 1, 5);

        }

        static private void PerformOption()
        {

            switch(numberOfChooise)
            {

                case 1:
                    AdditionScreen();
                    break;


                case 2:
                    SubtractionScreen();
                    break;


                case 3:
                    MultiplicationScreen();
                    break;


                case 4:
                    DivisionScreen();
                    break;


                case 5:
                    ShowPreviousResultScreen();
                    break;


            }

        }



        static public void ShowMenuScreen()
        {

            Console.Clear ();
            HeaderScreen();
            OptionsScreen();
            PerformOption();

        }

    }

}
