
using System;
using System.Threading.Tasks;

namespace Test
{
    public class StaffMember : IStaffWorker
    {
        public string Name { get; }

        public StaffMember(string name)
        {
            Name = name;
        }

        public virtual async Task HandleOrderAsync(Order order)
        {
            Console.WriteLine($"{Name} is starting to handle the {order.Category} order: {order.Item}");
            await Task.Delay(1000);
            Console.WriteLine($"{Name} has finished handling the order: {order.Item}");
        }
    }

}
