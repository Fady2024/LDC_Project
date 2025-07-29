using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Test
{
    class OrderManager
    {
        private readonly List<IStaffWorker> _staffList;
        private readonly IPrinter _printer;

        public OrderManager(List<IStaffWorker> staff, IPrinter printer)
        {
            _staffList = staff;
            _printer = printer;
        }

        public async Task HandleAsync(Order order)
        {
            var worker = _staffList.FirstOrDefault();
            if (worker == null)
            {
                Console.WriteLine("No staff available to handle the order.");
                return;
            }

            await worker.HandleOrderAsync(order);
            await _printer.PrintAsync(order, worker);
        }
    }
}
