using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Formats;
using System.Data;

namespace Calculator
{

    class Calculator
    {
        // The Main Method 
        static void Main(string[] args)
        {

            string value;
            do
            {
                Console.WriteLine("**************************************************");
            Console.WriteLine("| Simple Calculator Using Console Application |");
            Console.WriteLine("***************************************************");

           
                CalculatorApp app = new CalculatorApp(); // Using instance of a class


                app.Calculate(); // Calling the Calculate method inside my Calculator App class
            
            Console.ReadLine();
            Console.Write("Do you want to continue? (Y = Yes, N = No):"); 
            value = Console.ReadLine().ToUpper(); // Prompting the user continue or not
                Console.Clear();
           
            }
              while (value == "Y");
        } 
            
    }

}

