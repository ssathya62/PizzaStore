using PizzaStore.Shared;
using System;
using System.Collections.Generic;

namespace PizzaStore.Client.Pages
{
    public partial class Index
    {
        private State State { get; } = new State
        {
            Menu = new Menu
            {
                Pizzas = new List<Pizza>
                {
                    new Pizza(1,"Onion", 8.99M, Spiciness.Spicy),
                    new Pizza(2,"Jalapeño",7.99M, Spiciness.Hot),
                    new Pizza(3,"Pineapple", 9.25M, Spiciness.None)
                }
            }
        };

        protected static string SpicinessImage(Spiciness spiciness) => $"images/{spiciness.ToString().ToLower()}.png";

        protected void AddToBasket(Pizza pizza)
        {
            Console.WriteLine($"Added pizza {pizza.Name}");
            State.Basket.Add(pizza.Id);
        }

        protected void RemoveFromBasket(int pos)
        {
            Console.WriteLine($"Removing pizza at pos {pos}");
            State.Basket.RemoveAt(pos);
        }
        protected void PlaceOrder()
        {
            Console.WriteLine("Placing order");
            Console.WriteLine(State.ToJson());
            State.Basket.Orders.Clear();
        }
    }
}