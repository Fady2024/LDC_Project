using System.Threading.Tasks;

namespace Test
{
    public interface IPrinter
    {
        Task PrintAsync(Order order, IStaffWorker worker);
    }
}
