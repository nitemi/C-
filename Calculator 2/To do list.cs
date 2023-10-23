using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class ToDoList
    {
        enum UserInput
        {
            AddList = 1,
            DeleteList,
            Exit
        }
        public void DailyAct()
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                if (toDoList.Count > 0)
                {
                    Console.WriteLine("To-do List:");
                    Console.WriteLine("Enter the number of the list you want to delete:");

                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("-" + toDoList[i]);
                        Console.WriteLine("(" +  (i + 1) + ")" + toDoList[i]);
                    }
                    int listNum = int.Parse(Console.ReadLine());
                    listNum--;

                    if (listNum >= 0 && listNum < toDoList.Count) 
                    {
                        toDoList.RemoveAt(listNum);
                        Console.Clear();
                        Console.WriteLine("List deleted successfully!");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You currently have no list in your to do list.");
                    Console.WriteLine("");
                }
                Console.WriteLine("1....Add list");
                Console.WriteLine("2....Delete list");
                Console.WriteLine("3....Exit");
                int response = int.Parse(Console.ReadLine());

                if (response == (int)UserInput.AddList)
                {
                    Console.WriteLine("Enter List:");
                    string list = Console.ReadLine();
                    toDoList.Add(list);
                    Console.Clear();
                    Console.WriteLine("List added successfully");
                }
                else if (response == (int)UserInput.Exit)
                {
                    break;
                }
                else if (response == (int)UserInput.DeleteList)
                {

                }
          }
        }
    }
}
