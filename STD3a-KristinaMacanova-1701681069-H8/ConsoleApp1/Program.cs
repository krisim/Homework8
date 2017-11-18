using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        public static void Main()
        {
            string desire;
            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                desire = Console.ReadLine();

                if (desire == "yes")
                {
                    Console.WriteLine("Enter first number");
                    double firstNumber;
                    while (!double.TryParse(Console.ReadLine(), out firstNumber))
                        Console.WriteLine("That's not a double, please try again.");

                    Console.WriteLine("Enter second number");
                    double secondNumber;
                    while (!double.TryParse(Console.ReadLine(), out secondNumber))
                        Console.WriteLine("That's not a double, please try again.");

                    string operation;
                    do
                    {
                        Console.WriteLine("Enter operation");
                        operation = Console.ReadLine();
                    }
                    while (operation != "+" &&
                           operation != "-" &&
                           operation != "*" &&
                           operation != "/");

                    double result = 0;
                    bool err = false;
                    switch (operation)
                    {
                        case "+":
                            result = (firstNumber + secondNumber);
                            result = result * 1.1;
                            break;
                        case "-":
                            double maxNum = Math.Max(firstNumber, secondNumber);
                            double minNum = Math.Min(firstNumber, secondNumber);
                            result = maxNum * maxNum - minNum;
                            break;
                        case "*":
                            result = firstNumber * Math.Sqrt(secondNumber);
                            break;
                        case "/":
                            if (secondNumber == 0)
                            {
                                err = true;
                                Console.WriteLine("Error !!! You can't divide to 0 !!!");
                            }
                            else
                                result = firstNumber / secondNumber;
                            break;
                        default:
                            Console.WriteLine(operation + " is not a valid operation.");
                            err = true;
                            break;
                    }

                    if (!err)
                    {
                        Console.WriteLine("Result is " + result);
                        Console.WriteLine("\n***********************");
                        Console.WriteLine("***********************");
                        Console.WriteLine("***********************\n");
                    }
                }

            }
            while (desire != "no");
        }
    }
}
