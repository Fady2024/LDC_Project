using System;

using System.Threading.Tasks;

namespace Test
{
    public class Chef : StaffMember
    {
        public Chef(string name) : base(name) { }
        public override async Task HandleOrderAsync(Order order)
        {
            Console.WriteLine($"Chef {Name} is starting to prepare the {order.Category} order: {order.Item}");
            await Task.Delay(3000);
            Console.WriteLine($"Chef {Name} has finished preparing the order: {order.Item}");
        }

    }
}
