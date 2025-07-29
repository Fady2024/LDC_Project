using System;
using System.Collections.Generic;

namespace Test
{
    public interface IMenuDisplay
    {
        void DisplayMenu(Dictionary<string, List<string>> menuItems);
    }
}
