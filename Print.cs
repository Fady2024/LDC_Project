
using System;
using System.Threading.Tasks;

namespace Test
{
    public class Printer : IPrinter
    {
        public async Task PrintAsync(Order order, IStaffWorker worker)
        {
            Console.WriteLine("Printing receipt...");
            await Task.Delay(2000);
            Console.WriteLine("--- Receipt ---");
            Console.WriteLine($"Order: {order.Category} - {order.Item}");
            Console.WriteLine($"Handled by: {worker.Name}");
            Console.WriteLine("--- End of Receipt ---");
            Console.WriteLine();
        }
    }
}
