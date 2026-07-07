using System;

namespace CalculatorApp
{
    class Programone
    {
        static void Main(string[] args)
        {
            // Set up the console title
            Console.Title = "Basic C# Calculator";
            
            Console.WriteLine("=== Welcome to the C# Calculator ===");
            
            // Ask for the first number
            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Ask for the operator
            Console.Write("Enter an operator (+, -, *, /): ");
            string operation = Console.ReadLine();

            // Ask for the second number
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            // Determine calculation based on user input
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator chosen.");
                    validOperation = false;
                    break;
            }

            // Display the final result if calculation succeeded 
            if (validOperation)
            {
                Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result}");
            }

            // Keep the console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
