using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;


namespace Tasks {

    class Program {

        static void DisplayItems(List<string> tasks) {
            foreach(string task in tasks) {
                    Console.WriteLine(task);
            };
        }

        static void Main(string[] args) {
            List<string> tasks = new List<string> {"breakfast","gym","meeting"};

            Console.Write("Enter 1 to add items, 2 to remove and 3 to display: ");
            bool success = int.TryParse(Console.ReadLine(), out int option);
            Console.WriteLine();

            if (!success){
                Console.WriteLine("Please enter an integer");
            } else if (!new int[] {1,2,3}.Contains(option)) {
                Console.WriteLine("Please enter either 1,2 or 3");
            } else {
                if (option == 1) {
                    Console.Write("Enter number of items to add to list: ");
                    bool isnum = int.TryParse(Console.ReadLine().Trim().ToLower(), out int num_items);
                    if (!isnum) {
                        Console.WriteLine("Please enter an integer for number of items");
                    } else {
                        for (int i=0;i<num_items;i++) {
                            Console.Write($"Enter task {i+1} to add: ");
                            tasks.Add(Console.ReadLine().Trim().ToLower());
                            Console.WriteLine();
                        }
                        Console.WriteLine("Updated List: ");
                        DisplayItems(tasks);

                    };
                } else if (option==2) {
                    Console.Write("Enter item to delete: ");
                    string delete_item = Console.ReadLine().Trim().ToLower();
                    tasks.Remove(delete_item);
                    Console.WriteLine();
                    Console.WriteLine("Successfully deleted item!");

                    Console.WriteLine("Updated List: ");
                    DisplayItems(tasks);

                } else {
                    foreach(string task in tasks) {
                        Console.WriteLine(task);
                    };
                    Console.WriteLine("Sucessfully printed all the tasks!");
                };
            };

        }
    }
}
