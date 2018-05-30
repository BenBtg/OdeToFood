using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Restaurant(){Id = 1, Name = "Bens Balti House"};
            return View(model); 
        }
    }
}