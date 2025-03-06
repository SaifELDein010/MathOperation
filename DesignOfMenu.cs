
using System;
using CalculatorProject.utility;

namespace MathOperation
{
    class DesignOfMenu
    {
        static private int numberOfChooise = 0;
        static private void HeaderScreen()
        {

            Console.WriteLine("\t\t\t\t < - - Welcome to math operation - - >\n\n");

        }

        static private void OptionsScreen()
        {

            Console.WriteLine("\t\t\t\t\t [1] Addition              (+)");
            Console.WriteLine("\t\t\t\t\t [2] Subtraction           (-)");
            Console.WriteLine("\t\t\t\t\t [3] Multiplication        (*)");
            Console.WriteLine("\t\t\t\t\t [4] Division              (/)");
            Console.WriteLine("\t\t\t\t\t [5] Show previous result.");

            Console.WriteLine("\t\t\t\t\t ------------------------------");

            numberOfChooise = ReadInput.ReadNumberBetweenRange("\t\t\t\t\t  Enter your chooises: ", 1, 5);

        }

        static private void PerformOption()
        {

            switch(numberOfChooise)
            {

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

            }

        }



        static public void ShowMenuScreen()
        {

            HeaderScreen();
            OptionsScreen();
            PerformOption();

        }

    }

}
