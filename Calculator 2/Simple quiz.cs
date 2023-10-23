using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Formats.Asn1.AsnWriter;

namespace SimpleQuiz
{
    /* simple quiz:  
     Create a quiz ith multiple choice questions and 
     keep track of the player's score.
     */
    public partial class Quiz
    {
        int correctAnswer;
        int askQuestion = 1;
        int score = 1;
        int totalQuestion = 3;
    
       public void Q1()
        {

            Console.WriteLine("1.Which of the following is not a verb \n a.eat \n b.sleep \n c.jump \n d. blessing");
            char answer1 = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
            string output = (answer1 != 'd') ? "incorrect" : "Correct";
            Console.WriteLine(output);
            if (answer1 != 'd')
            {
                score++;
                Console.WriteLine("Correct, yoy just earned {} points, now at {}", score);
            }
            
        }
        public void Q2()
        {
           
            Console.WriteLine("1.Change 2.5 to proper fraction in its loest term \n a.1/4 \n b.3/5 \n c.5/7 \n d. none of the above");
            char answer2 = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
            string output2 = (answer2 != 'a') ? "incorrect" : "Correct";
            Console.WriteLine(output2);
            
        }
        public void Q3()
        {

            Console.WriteLine("1. Ade ______ football \n a.eat \n b.sleep \n c.plays \n d. drink");
            char answer3 = Convert.ToChar(Console.ReadLine());
            Console.ReadKey();
            string output3 = (answer3 != 'c') ? "incorrect" : "Correct";
            Console.WriteLine(output3);
           
        }
        public void Result()
        {
            Console.WriteLine();
        }
    }
}

