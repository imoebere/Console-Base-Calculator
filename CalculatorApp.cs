

namespace Calculator
{
    class CalculatorApp
    {
       
        public void Calculate()
        {
            All_Method method = new All_Method();
            try
            {
                // Varible Declaration and initialization
                double num1 = 0;
                double num2 = 0;
                string result;
                char @operator = ' ';


                // Prompting the input
                Console.Write("Enter Input 1: \t");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Input 2: \t");
                num2 = Convert.ToDouble(Console.ReadLine());

             
                @operator =  method.Operator();
                
                

                /*Using Tenary Operator to decide operation to be excuted.
                    Using String interpolation to Concatenate.
                 */

                result = (@operator == '+') ? ($"Your Result is {num1} + {num2} = {method.AddNumbers(num1, num2)}") : // Calling Addition Function
                          (@operator == '-') ? ($"Your Result is {num1} - {num2} = {method.SubstratNumbers(num1, num2)}") :// Calling Substration Function
                        (@operator == '*') ? ($"Your Result is {num1} * {num2} = {method.MultiplyNumbers(num1, num2)}") :// Calling Multiplication Function
                        (@operator == '/') ? ($"Your Result is {num1} / {num2} = {method.DivideNumbers(num1, num2)}") : // Calling Division Function
                        (@operator == '^') ? ($"Your Result is {num1} ^ {num2} = {method.ToPower(num1, num2)}") : // Calling Raise to power Function
                        (@operator == '%') ? ($"Your Reminder is: Modulus {num1} % {num2} = {method.Modulus(num1, num2)}") : // Calling Modulus Function.
                        ("Invalid Operator");

                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            }

    }
}
