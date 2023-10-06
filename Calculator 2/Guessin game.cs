using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /* (using multiline comment)
         Develop a game where the computer generates a random number
         and the player has to gues it within a certain number of attempts*/
    public class Guessin_game
    {
        public void Guess()
        {
            int[] guess;
            int count = 1;
            while (true) // used because continue and break statement in an if statement inside the while loop 
            {

                Console.WriteLine("Enter a number between 1 and 100");
                var num = Convert.ToDouble(Console.ReadLine());

                if (num < 1)
                {
                    Console.WriteLine("low, try again"); // execute if condition is true, if condition is false it moves to the next line of code
                    ++count;// means pre increment, value increases while executing this line
                    continue;/*it returns the control to the begining of the while loop 
                              i.e it skips the remaining statement in the loop and moves back to the top of the loop*/

                }
                else if (num > 100)
                {
                    Console.WriteLine("High, try again"); // execute if condition is true, if condition is false it moves to the next line of code
                    ++count;// means pre increment, value increases while executing this line
                    continue;/*it returns the control to the begining of the while loop
                             i.e it skips the remaining statement in the loop and moves back to the top of the loop*/
                }
                else
                {
                    Console.WriteLine("You guessed it! the number was " + num);
                    Console.WriteLine("It took you {0} {1}.  ", count, count == 1 ? "try" : "tries");
                    break;//use to exit or terminate the loop
                }
            }
        }
    }
}