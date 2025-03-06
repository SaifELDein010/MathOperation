

using System;
using CalculatorProject.utility;

namespace MathOperation
{
    class OperationLogic
    {

        static public int Addition(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);


            return number1 + number2;

        }

        static public int Subtraction(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);


            return number1 - number2;

        }

        static public int Multiplication(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);


            return number1 * number2;

        }

        static public int Division(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);


            if (number2 == 0)
            {

                Console.WriteLine("Undefiend");
                return 0;

            } else if(ReadInput.IsDoubleNumber(Convert.ToString(number1 / number2)))
            {

                Console.WriteLine("Can`t perfrom it, result will be not integer");
                return 0;

            }

            return number1 / number2;  

        }


    }


}
