using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Cal
    {
        int num1;//field
        int num2;//field
        public void calInput() //method
        {
            
            Console.Write("Enter a num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please select an option");
            Console.WriteLine("a for + ");
            Console.WriteLine("s for - ");
            Console.WriteLine("d for / ");
            Console.WriteLine("m for * ");

            var response = Convert.ToString(Console.ReadLine());

            switch (response)
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
            }
            Console.WriteLine("please press any key to exit");
            Console.Read();
            }
    }
 }
