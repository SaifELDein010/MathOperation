

using System;
using CalculatorProject.utility;
using System.Collections.Generic;

namespace MathOperation
{
    class OperationLogic
    {

        static private List<string> result = new List<string>();

        static public int Addition(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);

            result.Add($" {number1} + {number2} = {number1 + number2}");

            return number1 + number2;

        }

        static public int Subtraction(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);

            result.Add($" {number1} - {number2} = {number1 - number2}");

            return number1 - number2;

        }

        static public int Multiplication(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);

            result.Add($" {number1} * {number2} = {number1 * number2}");

            return number1 * number2;

        }

        static public int Division(string message1, string message2)
        {

            int number1 = ReadInput.ReadNumber(message1);
            int number2 = ReadInput.ReadNumber(message2);


            if (number2 == 0)
            {
                result.Add($" {number1} / {number2} = Undefiend");
                Console.WriteLine("\t Undefiend");
                return 0;

            } else if(ReadInput.IsDoubleNumber(Convert.ToString(number1 / number2)))
            {

                result.Add($" {number1} / {number2} = Can`t perfrom it, result will be not integer");
                Console.WriteLine("\t Can`t perfrom it, result will be not integer");
                return 0;

            }

            result.Add($" {number1} / {number2} = {number1 / number2}");
            return number1 / number2;  

        }


        static public List<string> GetResult()
        {

            return result;

        }

    }


}
