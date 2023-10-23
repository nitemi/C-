using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        /* (using multiline comment)
        Create a program that can perform basic arithemetic operation like
        addition, subtraction, multiplication and divion*/
        public void CalResult() // (using single line comment) method
        {

            Console.WriteLine("enter a num"); // asking for user input/info
            double num1 = Convert.ToDouble(Console.ReadLine()); // allow user input
            Console.WriteLine("enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            var response = Convert.ToString(Console.ReadLine());

            if (response == "a")//execute if condition is true, if condition is false it moves to the next line of code
            {
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            }
            else if (response == "s") // execute if condition is true, if condition is false it moves to the next line of code
            {
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            }
            else if (response == "m") //execute if condition is true, if condition is false it moves to the next line of code
            {
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            }
            else if (response == "d") // execute if condition is  true, if condition is false it moves to the next line of code
            {
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            }
            else //execute if none of this conditions hold

            {
                Console.WriteLine("invalid input");
            }
            }
        }
    }