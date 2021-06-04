using System.Collections.Generic;

namespace PizzaStore.Shared
{
    public class Basket
    {
        public Customer Customer { get; set; } = new();
        public List<int> Orders { get; set; } = new();
        public bool HasPaid { get; set; } = false;

        public void Add(int id)
        {
            Orders.Add(id);
        }

        public void RemoveAt(int index)
        {
            Orders.RemoveAt(index);
        }
    }
}