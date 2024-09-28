using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dynamic Calculator!");

        // Prompt the user for two numbers
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Ask the user to choose an operation
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.Write("Enter the number for your choice: ");
        string operation = Console.ReadLine();

        // Perform the calculation based on the user's input
        double result = 0;
        bool isValidOperation = true;

        switch (operation)
        {
            case "1":
                result = num1 + num2;
                Console.WriteLine($"The result of {num1} + {num2} is {result}");
                break;
            case "2":
                result = num1 - num2;
                Console.WriteLine($"The result of {num1} - {num2} is {result}");
                break;
            case "3":
                result = num1 * num2;
                Console.WriteLine($"The result of {num1} * {num2} is {result}");
                break;
            case "4":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of {num1} / {num2} is {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    isValidOperation = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                isValidOperation = false;
                break;
        }

        if (isValidOperation)
        {
            Console.WriteLine($"Final result: {result}");
        }

        // End of program
        Console.WriteLine("Thank you for using the Dynamic Calculator!");
    }
}
