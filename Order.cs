namespace Test
{
    public class Order
    {
        public string Category { get; }
        public string Item { get; }

        public Order(string category, string item)
        {
            Category = category;
            Item = item;
        }
    }
}
