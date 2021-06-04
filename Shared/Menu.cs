using System.Collections.Generic;
using System.Linq;

namespace PizzaStore.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new();
        public Pizza GetPizza(int id)
        {
            var pizza= Pizzas.SingleOrDefault(p => p.Id == id);
            return pizza;
        }
    }
}
