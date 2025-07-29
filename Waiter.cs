using System;

using System.Threading.Tasks;

namespace Test
{
    public class Waiter : StaffMember
    {
        public Waiter(string name) : base(name) { }

        public override async Task HandleOrderAsync(Order order)
        {
            Console.WriteLine($"Waiter {Name} is taking the {order.Category} order: {order.Item}");
            await Task.Delay(1500); 
            Console.WriteLine($"Waiter {Name} has delivered the order: {order.Item}");
        }
    }
}
