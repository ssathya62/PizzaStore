using System;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Shared
{
    public enum Spiciness
    {
        None,
        Spicy,
        Hot
    }
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Id = id;
            Name = name;
            Price = price;
            Spiciness = spiciness;
        }

        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
    }
}
