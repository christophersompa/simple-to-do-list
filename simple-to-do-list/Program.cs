﻿using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace simple_to_do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to my simple to do list!");

            List<string> tasks = new List<string>();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nCommands: Add, Delete, Edit, View & Quit");

                string userInput = Console.ReadLine();

                if (userInput == "Add")
                {
                    Console.WriteLine("\nPlease add a new task:");

                    string addTask = Console.ReadLine();

                    tasks.Add(addTask);

                    Console.WriteLine("Task added!");
                }
                else if (userInput == "Delete")
                {
                    Console.WriteLine("\nPlease enter index");

                    int index = Convert.ToInt32(Console.ReadLine());

                    tasks.RemoveAt(index);

                    Console.WriteLine("Task deleted!");
                }
                else if (userInput == "Edit")
                {
                    Console.WriteLine("\nEnter index you'd like to edit:");

                    int index = Convert.ToInt32(Console.ReadLine());

                    string editTask = Console.ReadLine();

                    tasks[index] = editTask;

                    Console.WriteLine("Changes made!");
                }
                else if (userInput == "View")
                {
                    Console.WriteLine("\nHere are your tasks:");

                    foreach (string task in tasks)
                    {
                        Console.WriteLine("- " + task);
                    }
                }
                else if (userInput == "Quit")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Unknown command!");
                }
            }
        }
    }
}
