namespace Training._03._03_AdvancedGenerics
{
    class Inventory<T, U>
    {
        private List<T> items = new List<T>();

        private Dictionary<U, T> _items = new Dictionary<U, T>();

        public void AddItem(T item, int quantity = 1)
        {
            for(int i = 0; i < quantity; i++)
            {
                items.Add(item);
                Console.WriteLine($"Item: {item}");
            }
        }

        public void AddItem(U key, T item)
        {
            _items[key] = item;
            Console.WriteLine($"Key: {key}, Item: {item}");
        }

    }

    class Inventory<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item, int quantity = 1)
        {
            for (int i = 0; i < quantity; i++)
            {
                items.Add(item);
                Console.WriteLine($"Item: {item}");
            }
        }
    }
}
