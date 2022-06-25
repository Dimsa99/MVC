using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class PizzaDatabase
    {
        public static List<Pizza> PIZZAS = new List<Pizza>()
        {
            new Pizza() { Id = 1, Name = "Margareta", Price = 10m, IsOnPromotion = false},
            new Pizza() { Id = 2, Name = "Capri", Price = 11m, IsOnPromotion = false},
            new Pizza() { Id = 3, Name = "Quatro", Price = 8.99m, IsOnPromotion = true}
        };
    }
}
