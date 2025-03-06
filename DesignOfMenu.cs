
using System;
using CalculatorProject.utility;

namespace MathOperation
{
    class DesignOfMenu
    {
        private int numberOfChooise = 0;
        private void HeaderScreen()
        {

            Console.WriteLine("\t\t\t\t < - - Welcome to math operation - - >");

        }

        private void OptionsScreen()
        {

            Console.WriteLine("\t [1] Addition       (+)");
            Console.WriteLine("\t [2] Subtraction    (-)");
            Console.WriteLine("\t [3] Multiplication (*)");
            Console.WriteLine("\t [4] Division       (/)");
            Console.WriteLine("\t [5] Show previous result.");

            Console.WriteLine("\t------------------------------");

            numberOfChooise = ReadInput.ReadNumberBetweenRange("\tEnter your chooises: ", 1, 5);

        }

        private void PerformOption()
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



        public void ShowMenuScreen()
        {

            HeaderScreen();
            OptionsScreen();
            PerformOption();

        }

    }

}
