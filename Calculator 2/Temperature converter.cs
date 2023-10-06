using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    /* (using multiline comment)
     Design a program that coverts temperature etween farenheit and celsius*/
    public class Tconverter
    {
        public void TempConvert()
        {
            Console.WriteLine("enter value ");
            double value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please choose an option");
            Console.WriteLine("f .........convert to farenheit");
            Console.WriteLine("c...........convert to celsius");
            var response = Convert.ToString(Console.ReadLine());

            if (response == "f")
            {
                Console.WriteLine($"Your result is ({value}F + 32) * (9/5) = " + (value + 32) * 9/5);
            }
            else if (response == "c")

            {
                Console.WriteLine($"Your result is ({value}C - 32) * (5/9) = " + (value - 32) * 5/9);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
