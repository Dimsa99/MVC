using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaDatabase.PIZZAS;
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            Pizza pizza = PizzaDatabase.PIZZAS.FirstOrDefault(x => x.Id == id);
            if( pizza is null)
            {
                return RedirectToAction("Error");
            }
            return View(pizza);
        }
    }
}
