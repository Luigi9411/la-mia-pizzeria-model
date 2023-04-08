using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using var ctx = new PizzaContext();

            var pizzas = ctx.Pizzas.ToArray();

            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {

            using var ctx = new PizzaContext();

            var pizza = ctx.Pizzas.Find(id);

            return View(pizza);
        }
    }
}
