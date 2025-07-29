using System;

using System.Threading.Tasks;

namespace Test
{
    public class Bartender : StaffMember
    {
        public Bartender(string name) : base(name) { }
        public override async Task HandleOrderAsync(Order order)
        {
            Console.WriteLine($"Bartender {Name} is preparing the {order.Category} order: {order.Item}");
            await Task.Delay(2000).ConfigureAwait(false);
            Console.WriteLine($"Bartender {Name} has finished preparing the drink: {order.Item}");
        }
    }
}
