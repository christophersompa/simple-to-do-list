using System.Globalization;

namespace simple_to_do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to my simple to do list!");

            Console.WriteLine("Commands: Add, Delete, Edit, View and Mark.");

            List<string> tasks = new List<string>();

            string userInput = Console.ReadLine();

            while (userInput != "End")
            {

                if (userInput == "Add")
                {
                    int taskNumber = 1;

                    Console.WriteLine("Please add a new task:");

                    string addTask = Console.ReadLine();

                    tasks.Add(taskNumber + ". " + addTask + "=Incomplete");

                }
                else if (userInput == "Delete")
                {

                }
                else if (userInput == "Edit")
                {

                }
                else if (userInput == "View")
                {
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                }
                else if (userInput == "Mark")
                {

                }
                else
                {
                    Console.WriteLine("Unknown command!");
                }
            }
        }
    }
}
