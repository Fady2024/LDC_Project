using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void FadyBanner()
        {
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------+\n");
            Console.WriteLine("|  $$$$$$     $$        $$$$$$      $$     $$       $$$$$$    $$$$$$  $$$$$$     $$$$$$    $$$$$$  $$$$$$  |\n");
            Console.WriteLine("|  $$        $$ $$      $$    $$     $$   $$      $$          $$      $$   $$   $$         $$      $$      |\n");
            Console.WriteLine("|  $$$$$$   $$$$$$$     $$     $$     $$ $$       $$   $$$$   $$$$$$  $$$$$$$   $$  $$$$   $$$$$$  $$$$$$  |\n");
            Console.WriteLine("|  $$      $$     $$    $$    $$       $$         $$     $$   $$      $$   $$   $$    $$   $$          $$  |\n");
            Console.WriteLine("|  $$     $$       $$   $$$$$$         $$          $$$$$$     $$$$$$  $$    $$   $$$$$$    $$$$$$  $$$$$$  |\n");
            Console.WriteLine("|                                                                                                          |\n");
            Console.WriteLine("|                               $$   $$   $$$$    $$$$$     $$$$$$  $$     $$                              |\n");
            Console.WriteLine("|                               $$  $$   $$   $$  $$   $$   $$       $$   $$                               |\n");
            Console.WriteLine("|                               $$ $$    $$   $$  $$    $$  $$$$$$    $$ $$                                |\n");
            Console.WriteLine("|                               $$  $$   $$   $$  $$   $$       $$     $$                                  |\n");
            Console.WriteLine("|                               $$   $$   $$$$    $$$$$     $$$$$$     $$                                  |\n");
            Console.WriteLine("|                                                                                                          |\n");
            Console.WriteLine("+----------------------------------------------------------------------------------------------------------+\n\n");
        }

        static async Task Main(string[] args)
        {
            FadyBanner();

            var menu = new Menu();
            IMenuDisplay menuDisplayer = new MenuDisplayer();
            IPrinter printer = new Printer();

            Console.WriteLine("Please select a staff member:");
            var staffList = new List<IStaffWorker>
            {
                new Chef("Chef Mohamed"),
                new Waiter("Waiter Ahmed"),
                new Bartender("Bartender Ali")
            };

            for (int staffIndex = 0; staffIndex < staffList.Count; staffIndex++)
            {
                Console.WriteLine($"{staffIndex + 1}. {staffList[staffIndex].Name}");
            }

            Console.Write("Enter the number of the staff member: ");
            int staffChoice;
            while (!int.TryParse(Console.ReadLine(), out staffChoice) || staffChoice < 1 || staffChoice > staffList.Count)
            {
                Console.Write($"Invalid choice. Please enter a number between 1 and {staffList.Count}: ");
            }

            IStaffWorker selectedStaff = staffList[staffChoice - 1];
            Console.WriteLine($"You selected: {selectedStaff.Name}");

            var orderManager = new OrderManager(staffList, printer);

            Console.WriteLine("\nPlease select an order category:");
            var menuItems = menu.GetMenuItems();
            var categories = new List<string>(menuItems.Keys);

            for (int categoryIndex = 0; categoryIndex < categories.Count; categoryIndex++)
            {
                Console.WriteLine($"{categoryIndex + 1}. {categories[categoryIndex]}");
            }

            Console.Write("Enter the number of the category: ");
            int categoryChoice;
            while (!int.TryParse(Console.ReadLine(), out categoryChoice) || categoryChoice < 1 || categoryChoice > categories.Count)
            {
                Console.Write($"Invalid choice. Please enter a number between 1 and {categories.Count}: ");
            }

            string selectedCategory = categories[categoryChoice - 1];
            Console.WriteLine($"You selected category: {selectedCategory}");

            var items = menuItems[selectedCategory];
            Console.WriteLine("\nPlease select an item:");

            for (int itemIndex = 0; itemIndex < items.Count; itemIndex++)
            {
                Console.WriteLine($"{itemIndex + 1}. {items[itemIndex]}");
            }

            Console.Write("Enter the number of the item: ");
            int itemChoice;
            while (!int.TryParse(Console.ReadLine(), out itemChoice) || itemChoice < 1 || itemChoice > items.Count)
            {
                Console.Write($"Invalid choice. Please enter a number between 1 and {items.Count}: ");
            }

            string selectedItem = items[itemChoice - 1];
            Console.WriteLine($"You selected item: {selectedItem}");

            var order = new Order(selectedCategory, selectedItem);
            await orderManager.HandleAsync(order);
        }
    }
}
