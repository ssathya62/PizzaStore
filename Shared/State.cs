using System.Linq;

namespace PizzaStore.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new();
        public Basket Basket { get; set; } = new();
        public UI Ui { get; set; } = new();
        public decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id).Price);
    }
}