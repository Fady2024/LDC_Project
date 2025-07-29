

namespace Test
{
    public class MenuDisplayer : IMenuDisplay
    {
        public void DisplayMenu(Dictionary<string, List<string>> menuItems)
        {
            Console.WriteLine("------ MENU ------");
            foreach (var category in menuItems)
            {
                Console.Write($"{category.Key}: ");
                Console.WriteLine(string.Join(", ", category.Value));
            }
        }
    }
}
