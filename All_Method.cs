using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class All_Method
    {
        //Function to Add Two Numbers 
        public double AddNumbers(double num1, double num2)
        {
            return (num1 + num2);
        }

        //Function to Substract Two Numbers
        public double SubstratNumbers(double num1, double num2)
        {
            return (num1 - num2);
        }

        //Function to Multiply Two Numbers
        public double MultiplyNumbers(double num1, double num2)
        {
            return (num1 * num2);
        }

        //Function to Divide Two Numbers
        public double DivideNumbers(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("You can not divide by 0");
                return num2;
            }
            else
            {
                return (num1 / num2);

            }
        }
        // Function for raising num1 to the power of num2
        public double ToPower(double num1, double num2)
        {
            double answer = Math.Pow(num1, num2);
            return answer;
        }

        public double Modulus(double num1, double num2)
        {
            double answer = (num1 % num2);
            return answer;
        }
        public char Operator()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("| Select an Operator: |");
            Console.WriteLine("************************");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Substract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.WriteLine("\t^ : Exponential");
            Console.WriteLine("\t% : Remainder");

            char @operator = Convert.ToChar(Console.Read());
           return @operator;
        }
    }
}
