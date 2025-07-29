
using System.Threading.Tasks;

namespace Test
{
    public interface IStaffWorker
    {
        string Name { get; }
        Task HandleOrderAsync(Order order);
    }
}