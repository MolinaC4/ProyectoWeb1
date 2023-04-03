using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb1.Controllers
{
    public class SintomasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
