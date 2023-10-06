using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    /* (using multiline comment)
        Create a program that can perform basic arithemetic operation like
        addition, subtraction, multiplication and divion*/
    public class scienceCal
    {
        int num1;//field
        int num2;//field
        public void Mycal() //method
        {

            Console.Write("Enter a num: "); //ask for user input
            double num1 = Convert.ToDouble(Console.ReadLine()); // hello user input

            Console.Write("Enter another num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please select an option");
            Console.WriteLine("1 for + ");
            Console.WriteLine("2 for - ");
            Console.WriteLine("3 for / ");
            Console.WriteLine("4 for * ");

            var option = Convert.ToString(Console.ReadLine());
       
            if (option == "1") 
            {
                Console.WriteLine("num1 + num2"); // execute if condition is true, if condition is false it moves to the next line of code
            }
            if (option == "2")
            {
                Console.WriteLine(num1 - num2); // execute if condition is true, if condition is false it moves to the next line of code
            }
            if (option == "3")
            {
                Console.WriteLine(num1 / num2); // execute if condition is true, if condition is false it moves to the next line of code
            }
            if (option == "4")
            {
                Console.WriteLine(num1 * num2); // execute if condition is true, if condition is false it moves to the next line of code
            }
            else
            {
                Console.WriteLine("syntax error"); // execute if all condition is false
            }
        }
    }
}
