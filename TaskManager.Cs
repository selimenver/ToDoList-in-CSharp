using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)

        {

            Console.WriteLine("Welcome to task manager.");
            Console.WriteLine("Type 1 to view your tasks");
            Console.WriteLine("Type 2 to add a task");
            Console.WriteLine("Type 3 to exit");
            char Choice = Convert.ToChar(Console.ReadLine());

            if (Choice == '1')
            {
                foreach (string task in tasks)
                {
                    Console.WriteLine("Your tasks:");
                    Console.WriteLine(task);
                }
            }
            else if (Choice == '2')
            {
                Console.Write("Add a task. \n");
                string adder = Console.ReadLine();
                tasks.Add(adder);
                Console.WriteLine("The task has been added.");
            }
            else if (Choice == '3')
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter a valid option");
            }
        }
    }
}




