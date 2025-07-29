using System;
using System.Collections.Generic;

namespace Test
{
    public class Menu
    {
        private readonly Dictionary<string, List<string>> _menuItems;

        public Menu()
        {
            _menuItems = new Dictionary<string, List<string>>
            {
                { "Food", new List<string> { "Burger", "Pizza", "Pasta" } },
                { "Drink", new List<string> { "Juice", "Tea", "Coffee" } },
                { "Dessert", new List<string> { "Cake", "IceCream", "Donut" } }
            };
        }

        public Dictionary<string, List<string>> GetMenuItems() => _menuItems;
    }

}
